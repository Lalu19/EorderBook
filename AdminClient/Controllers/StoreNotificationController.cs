using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AdminClient.DTO;
using AdminClient.Model.StoreNotification;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;


namespace AdminClient.Controllers
{
    public class StoreNotificationController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IStoreNotification _storenotification;
        public StoreNotificationController(IWebHostEnvironment hostingEnvironment,
                                            IStoreNotification storenotification)
        {
            _hostingEnvironment = hostingEnvironment;
            _storenotification = storenotification;
        }
        [HttpPost]
        public IActionResult CreateNotification(StoreNotificationDTO storeNotificationDTO)
        {
            string filename = ContentDispositionHeaderValue.Parse(storeNotificationDTO.file.ContentDisposition).FileName.Trim('"');
            filename = EnsureCorrectFilename(filename);

            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
            string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
            storeNotificationDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
            string photopath = "/images/" + uniqueFileName;
            StoreNotificationNewDTO Notification = new StoreNotificationNewDTO();
            Notification.Status = storeNotificationDTO.Status;
            Notification.Remark = storeNotificationDTO.Remark;
            Notification.StoreImage = photopath;
            Notification.AgentId = storeNotificationDTO.AgentId;
            Notification.StoreId = storeNotificationDTO.StoreId;
            Notification.CreatedBy = storeNotificationDTO.CreatedBy;
            var a = _storenotification.CreateNotification(Notification);
            return Ok(a);
        }
        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }

    }
}
