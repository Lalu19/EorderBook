using System;

namespace AdminApi.Models.App.ProductMaster
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
