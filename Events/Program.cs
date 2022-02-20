using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product(50);
            product.ProductName = "Harddisk";

            Product product1 = new Product(50);
            product1.ProductName = "GSM";
            product1.StockControlEvent += Product1_StockControlEvent;

            for (int i = 1; i <= 10; i++)
            {
                product.Sell(10);
                product1.Sell(10);
                Console.ReadLine();
            }


            Console.ReadLine();
        }

        private static void Product1_StockControlEvent()
        {
            Console.WriteLine("GSM is about to finish");
        }
    }
}
