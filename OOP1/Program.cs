// See https://aka.ms/new-console-template for more information
using OOP1;
Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitInStock = 3;

Product Product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

ProductManager productManager =new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);
