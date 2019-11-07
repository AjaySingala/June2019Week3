using System;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Authorization;

namespace EFLayers.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }

        //public IdentityUser User { get; set; }
    }
}
