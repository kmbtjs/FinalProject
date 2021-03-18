using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine("{0} ", product.ProductName);
            //}
            ProductManager productManager1 = new ProductManager(new EfProductDal());
            foreach (var product in productManager1.GetByUnitPrice(50,500))
            {
                Console.WriteLine("Product Name: {0} Product Price: {1} Current Stock: {2} ", product.ProductName, product.UnitPrice, product.UnitsInStock);
            }
        }
    }
}
