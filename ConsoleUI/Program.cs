// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//Data Transformation Object
ProductTest();
//CategoryTest();







static void ProductTest()
{
    ProductManager productManager = new(new EfProductDal());

    var result = productManager.GetProductDetails();

    if (result.Success)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + " " + product.CategoryName);
        }
    }
    else 
    {
        Console.WriteLine(result.Message);
    }


}

static void CategoryTest()
{
    CategoryManager categoryManager = new(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}