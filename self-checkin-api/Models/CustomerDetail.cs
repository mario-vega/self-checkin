using System;

namespace self_checkin_api.Models
{
    public class CustomerDetail
    {
        public int Id { get; set; }
        public DateTime AssistanceDate { get; set; }
        public int CustomerId { get; set; }
    }
}
