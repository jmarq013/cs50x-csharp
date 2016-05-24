using ProductLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Major_Mart
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager mart = new ProductManager(50);

            Product celery = new Product();
            celery.name = "celery";
            celery.price = 1.99;
            celery.quantity = 30;
            celery.category = "vegetable";
            //mart.AddProduct(celery);

            Console.WriteLine("Testing Search....");
            mart.Search("celery");

            //mart.RemoveProduct("celery");
            //mart.Search("celery");

            Console.ReadLine();
        }
    }
}
