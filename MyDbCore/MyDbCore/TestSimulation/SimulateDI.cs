using MyDbCore.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDbCore.TestSimulation
{
    public class SimulateDI
    {
        public void Call()
        {
            var bl = new CustomerTestBL();
            CustomersController controller = new CustomersController(bl);
            var list = controller.Index();
        }

    }
}
