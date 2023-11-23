using System;

namespace AdminApi.Models.App.Agent
{
    public class Agent
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentPhoneNumber { get; set; }
        public string Address { get; set; }
        public string PinCode { get; set; }
        public string ProfilePhoto { get; set; }
        public string AgentuserId { get; set; }
        public string PassWord { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
