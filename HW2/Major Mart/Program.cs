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
            mart.AddProduct(celery);

            string userOption;

            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Search Product");
                Console.WriteLine("4. Update Product Price");
                Console.WriteLine("5. Update Product Quantity");
                Console.WriteLine("6. Display Total Inventory");
                Console.WriteLine("7. Print Product List");
                Console.WriteLine("8. Exit");
                Console.WriteLine();

                userOption = Console.ReadLine();

                // ADD PRODUCT
                if (userOption == "1")
                {
                    Console.WriteLine("Enter product name: ");
                    string name = Console.ReadLine();

                    Product newProduct = new Product();
                    newProduct.name = name;

                    while (true)
                    {
                        Console.WriteLine("Enter product price: ");
                        string cost = Console.ReadLine();
                        double price;

                        if (double.TryParse(cost, out price))
                        {
                            newProduct.price = price;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid price.");
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("Enter product quantity: ");
                        string stock = Console.ReadLine();
                        int quantity;

                        if (int.TryParse(stock, out quantity))
                        {
                            newProduct.quantity = quantity;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid quantity.");
                        }
                    }

                    Console.WriteLine("Enter product category: ");
                    string category = Console.ReadLine();

                    newProduct.category = category;
                    
                    if (mart.AddProduct(newProduct))
                    {
                        Console.WriteLine("Product added.");
                    }
                    
                    Console.WriteLine();
                }

                // REMOVE PRODUCT
                else if (userOption == "2")
                {
                    Console.WriteLine("Enter product name to be removed");
                    string remove = Console.ReadLine();

                    if (mart.RemoveProduct(remove))
                    {
                        Console.WriteLine(remove + " removed.");
                    }

                    Console.WriteLine();
                }

                // SEARCH PRODUCT
                else if (userOption == "3")
                {
                    Console.WriteLine("Enter product name: ");
                    string search = Console.ReadLine();
                    Console.WriteLine();

                    mart.Search(search);
                    Console.WriteLine();
                }

                // UPDATE PRICE
                else if (userOption == "4")
                {
                    Console.WriteLine("Enter product name: ");
                    string product = Console.ReadLine();

                    if (mart.Search(product))
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter new product price: ");
                            string cost = Console.ReadLine();
                            double price;

                            if (double.TryParse(cost, out price))
                            {
                                mart.UpdatePrice(product, price);
                                Console.WriteLine(product + " price updated to " + price);
                                Console.WriteLine();
                                break;
                            }
                        }
                    }
                }

                // UPDATE QUANTITY
                else if (userOption == "5")
                {
                    Console.WriteLine("Enter product name: ");
                    string product = Console.ReadLine();

                    if (mart.Search(product))
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter new product quantity: ");
                            string cost = Console.ReadLine();
                            int quantity;

                            if (int.TryParse(cost, out quantity))
                            {
                                mart.UpdateQuantity(product, quantity);
                                Console.WriteLine(product + " quantity updated to " + quantity);
                                Console.WriteLine();
                                break;
                            }
                        }
                    }
                }

                // DISPLAY TOTAL INVENTORY
                else if (userOption == "6")
                {
                    mart.DisplayTotal();
                    Console.WriteLine();
                }

                // PRINT PRODUCT LIST
                else if (userOption == "7")
                {
                    mart.ProductList();
                    Console.WriteLine();
                }

                // EXIT
                else if (userOption == "8")
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
