using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    interface ICustomerValidation
    {
        bool validate(Customer customer); 
    }
}
