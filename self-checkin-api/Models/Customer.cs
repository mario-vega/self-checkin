using System;

namespace self_checkin_api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyPhone { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
