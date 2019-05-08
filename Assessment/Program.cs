using Assessment.Assessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Good> basket1 = new List<Good>();
            List<Good> basket2 = new List<Good>();
            List<Good> basket3 = new List<Good>();

            basket1.Add(new Good("book", "Book", 12.49, false));
            basket1.Add(new Good("music CD", "Music", 14.99, false));
            basket1.Add(new Good("chocolate bar", "Food", 0.85, false));

            basket2.Add(new Good("box of chocolates", "Food", 10.00, true));
            basket2.Add(new Good("bottle of perfume", "Cosmetic", 47.50, true));

            basket3.Add(new Good("bottle of perfume", "Cosmetic", 27.99, true));
            basket3.Add(new Good("bottle of perfume", "Cosmetic", 18.99, false));
            basket3.Add(new Good("packet of headache pills", "Medical", 9.75, false));
            basket3.Add(new Good("box of chocolates", "Food", 11.25, true));

            double tax = 0.0;
            double total = 0.0;
            Console.WriteLine("Output 1:");
            foreach (Good good in basket1) {  
                good.applyTax(good);
                tax += good.SalesTax;
                total += good.Cost;
                good.printReceipt(good);
            }
            Console.WriteLine("    Sales Taxes: " + String.Format("{0:0.00}", tax));
            Console.WriteLine("    Total: " + String.Format("{0:0.00}", total));

            tax = 0.0;
            total = 0.0;
            Console.WriteLine("Output 2:");
            foreach (Good good in basket2)
            {
                good.applyTax(good);
                tax += good.SalesTax;
                total += good.Cost;
                good.printReceipt(good);
            }
            Console.WriteLine("    Sales Taxes: " + String.Format("{0:0.00}", tax));
            Console.WriteLine("    Total: " + String.Format("{0:0.00}", total));

            tax = 0.0;
            total = 0.0;
            Console.WriteLine("Output 3:");
            foreach (Good good in basket3)
            {
                good.applyTax(good);
                tax += good.SalesTax;
                total += good.Cost;
                good.printReceipt(good);
            }
            Console.WriteLine("    Sales Taxes: " + String.Format("{0:0.00}", tax));
            Console.WriteLine("    Total: " + String.Format("{0:0.00}", total));

            Console.ReadKey();
        }
    }
}
