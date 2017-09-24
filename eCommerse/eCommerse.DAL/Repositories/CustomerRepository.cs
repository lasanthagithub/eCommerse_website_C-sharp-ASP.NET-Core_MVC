using eCommerse.Model;
using eCommerse.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.DAL.Repositories;

namespace eCommerse.DAL.Repositories
{
    public class CustomerRepository: RepositoryBase<Customer>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentException();
        }
    }
}
