// See https://aka.ms/new-console-template for more information
using Shopping;
CustomerManager customerManager = new CustomerManager(new CustomerValidationManager());
customerManager.Add(new Customer { Id = 1, BirthYear = 2001, CustomerName = "Ahmet", CustomerLastName = "K", IdentityNumber = 1234 });
customerManager.Delete(new Customer { Id=2});
customerManager.Update(new Customer { Id=3});
