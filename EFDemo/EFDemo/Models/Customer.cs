﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}