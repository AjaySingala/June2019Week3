using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01WebApp.Models.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(int id);
        //IList<Customer> Get();
        //void Create();
        //Customer Update(int id, Customer customer);
        //bool Delete(int id);
    }
}
