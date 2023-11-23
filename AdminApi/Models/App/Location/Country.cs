using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AdminApi.Models.App.Location
{
    public class Country
    {
         
        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }

}

