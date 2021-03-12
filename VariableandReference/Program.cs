using System;

namespace VariableandReference
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,double,bool -- değer tip
            //array,class,interface -- reference tip

            Console.WriteLine("Hello World!");

            int sayi1 = 30;
            Console.WriteLine(sayi1);
            int sayi2 = 20;
            Console.WriteLine(sayi2);
            sayi1 = sayi2;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            sayi2 = 60;
            
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi1);
        }
    }
}
