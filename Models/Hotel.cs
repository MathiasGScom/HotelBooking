﻿namespace Models
{
    public class Hotel : Common
    {
        public String name { get; set; }
        public String phoneNumber { get; set; }
        public String address { get; set; }
        public List<Admin>? admins { get; set; }
        public List<Customer>? customers { get; set; }
        public List<Room>? rooms { get; set; }
    }
}