using System;

namespace self_checkin_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string ContactPhone { get; set; }
        public DateTime HiringDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
