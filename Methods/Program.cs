using System;
// Do not repeat yourself - Clean Code - Best Practice

namespace ClassMethodDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Serra Nur Akmese";
            product1.ID = 1;
            product1.Phone = "00000000000";

            Product product2 = new Product();
            product2.Name = "Furkan Polat";
            product2.ID = 2;
            product2.Phone = "00000000001";

            Product[] products = new Product[] { product1, product2 };
            //// type-safe
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.Caption);
            //    Console.WriteLine(product.Name);
            //    Console.WriteLine(product.Price);
            //    Console.WriteLine("-----------------------");
            //}

            //Console.WriteLine("--------Methods--------");
            
            ////Instance


            AddManager addManager = new AddManager();

            addManager.Add(product1);
            addManager.Delete(product2);
            addManager.Listing(products);
            //addManager.Add2("Highlighter","Hot Mama", 65.99,100); 



        }
    }
}
