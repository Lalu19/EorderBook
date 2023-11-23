using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AdminClient.DTO;
using AdminClient.Model.CreditHistory;
using AdminClient.Model.MobileUpload;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CreditHistoryController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ICreditHistory _CreditHistory;
        public CreditHistoryController(IWebHostEnvironment hostingEnvironment,
                                            ICreditHistory CreditHistory)
        {
            _hostingEnvironment = hostingEnvironment;
            _CreditHistory = CreditHistory;
        }
        [HttpPost]
        public IActionResult TransactionCreate(CreditHistoryDTO creditHistoryDTO)
        {
            string filename = ContentDispositionHeaderValue.Parse(creditHistoryDTO.file.ContentDisposition).FileName.Trim('"');
            filename = EnsureCorrectFilename(filename);

            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
            string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
            creditHistoryDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
            string photopath = "/images/" + uniqueFileName;
            CreditHistoryNewDTO CreditHistory = new CreditHistoryNewDTO();
            CreditHistory.StoreId = creditHistoryDTO.StoreId;
            CreditHistory.CreditBalance = creditHistoryDTO.CreditBalance;
            CreditHistory.DebitBalance = creditHistoryDTO.DebitBalance;
            CreditHistory.TotalOutstanding = creditHistoryDTO.TotalOutstanding;
            CreditHistory.Receipt = photopath;
            CreditHistory.AgentId = creditHistoryDTO.AgentId;
            CreditHistory.CreatedBy = creditHistoryDTO.CreatedBy;

            var a = _CreditHistory.CreateTransaction(CreditHistory);

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
