using System;

namespace self_checkin_api.Models
{
    public class UserDetail
    {
        public int Id { get; set; }
        public DateTime LoggingDate { get; set; }
        public int UserId { get; set; }
    }
}
