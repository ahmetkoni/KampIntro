using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class CustomerValidationManager : ICustomerValidation
    {



        bool ICustomerValidation.validate(Customer customer)
        {
            if (customer.Id == 1 && customer.BirthYear == 2001 && customer.IdentityNumber == 1234 && customer.CustomerName == "Ahmet" && customer.CustomerLastName == "K")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
