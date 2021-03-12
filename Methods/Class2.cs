using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class AddManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added : " + product.Name);
            Console.WriteLine("----------------------------------");
        }

        //public void Add2(string name,string caption, double price, int stock)
        //{
        //    Console.WriteLine("Add to Card : " + name);
        //}

        public void Listing(Product[] productarray)
        {
            foreach (var product in productarray)
            {
                Console.WriteLine("Consumer ID : " + product.ID);
                Console.WriteLine("Consumer Name-Surname : " + product.Name);
                Console.WriteLine("Consumer Phone : " + product.Phone);
                Console.WriteLine("----------------------------------");
            }

        }

        public void Delete(Product product)
        {

            Console.WriteLine("Deleted : " + product.Name);
            Console.WriteLine("----------------------------------");


        }
    }
}
