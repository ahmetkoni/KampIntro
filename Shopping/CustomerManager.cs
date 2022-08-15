using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class CustomerManager : ICustomerService
    {
        ICustomerValidation _customerValidation;
        public CustomerManager(ICustomerValidation customerValidation)
        {
            _customerValidation = customerValidation;
        }

        public void Add(Customer customer)
        {
            if (_customerValidation.validate(customer) == true)
            {
                Console.WriteLine("Customer'a alışveriş kartı verildi.");
            }
            else
            {
                Console.WriteLine("Customer'a alışveriş kartı verilmedi");
            }
                   
        }

        public void Delete(Customer customer)
        {
            if (_customerValidation.validate(customer) == true) 
            {
                Console.WriteLine("Customer'ın alışveriş kartı iptal edildi.");
            }

             else
            {
                Console.WriteLine("Customer'ın alışveriş kartı iptal edilmedi");
            }

        }

        public void Update(Customer customer)
        {
            if (_customerValidation.validate(customer) == true)
            {
                Console.WriteLine("Customer'ın alışveriş kartının limiti yükseltildi");
            }
            else
            {
                Console.WriteLine("Customer'ın alışveriş kartının limiti yükseltilmedi");
            }
        }

    }
}
