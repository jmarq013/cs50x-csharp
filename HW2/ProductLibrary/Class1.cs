using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class ProductManager
    {
        Product[] Inventory;

        public ProductManager(int limit)
        {
            Inventory = new Product[limit];
        }

        public bool AddProduct(Product product)
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] == null)
                {
                    Inventory[i] = product;
                    return true;
                }
            }

            Console.WriteLine("Product could not be added to the inventory.");
            return false;
        }

        public bool RemoveProduct(string product)
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] != null)
                {
                    if (Inventory[i].name == product)
                    {
                        Inventory[i] = null;
                        Console.WriteLine(product + " removed.");
                        return true;
                    }
                }
            }

            Console.WriteLine("Product not found in the inventory.");
            return false;
        }

        public bool Search(string product)
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] != null)
                {
                    if (Inventory[i].name == product)
                    {
                        Console.WriteLine("name: " + Inventory[i].name);
                        Console.WriteLine("price: " + Inventory[i].price);
                        Console.WriteLine("quantity: " + Inventory[i].quantity);
                        Console.WriteLine("category: " + Inventory[i].category);

                        return true;
                    }
                }
            }

            Console.WriteLine("Product was not found.");
            return false;
        }

        public void UpdatePrice(string product, double price)
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] != null)
                {
                    if (Inventory[i].name == product)
                    {
                        Inventory[i].price = price;
                        return;
                    }
                }
            }
        }

        public void UpdateQuantity(string product, int quantity)
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] != null)
                {
                    if (Inventory[i].name == product)
                    {
                        Inventory[i].quantity = quantity;
                        return;
                    }
                }
            }
        }

        public int DisplayTotal()
        {
            int total = 0;
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] != null)
                {
                    total += Inventory[i].quantity;
                }
            }

            return total;
        }

        public void ProductList()
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] != null)
                {
                    Console.WriteLine("#" + i + "==> " + Inventory[i].name);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
