using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App.OrderDTO
{
    public class OrderDTO
    {
        public int StoreId { get; set; }
        public int AgentId { get; set; }
        public string TotalPrice { get; set; }
        public int CreatedBy { get; set; }
        public List<OrderDetailsDTO> OrderDetails { get; set; }
    }
    
    public class OrderDetailsDTO
    {
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ProductDetailsId { get; set; }
        public string PackagingType { get; set; }
        public string Quantity { get; set; }
        public string Mrp { get; set; }
        public string SellingPrice { get; set; }
        public int CreatedBy { get; set; }
    }

}
