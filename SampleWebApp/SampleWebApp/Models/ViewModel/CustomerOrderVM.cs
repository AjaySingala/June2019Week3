using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApp.Models.ViewModel
{
    public class CustomerOrderVM
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
