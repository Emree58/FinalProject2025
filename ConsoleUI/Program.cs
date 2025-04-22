// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new(new EfProductDal());

foreach (var product in productManager.GetByUnitPrice(40,100))
{
    Console.WriteLine(product.ProductName);
}