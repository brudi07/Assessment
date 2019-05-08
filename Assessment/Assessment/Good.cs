using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Assessment
{
    class Good : IGood
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public double SalesTax { get; set; }
        public bool Import { get; set; }

        public Good(string name, string type, double cost, bool import)
        {
            Name = name;
            Type = type;
            Cost = cost;
            SalesTax = 0.0;
            Import = import;
        }

        /// <summary>
        /// Calculate the sales tax
        /// </summary>
        /// <param name="tax">Tax to apply</param>
        /// <returns>The cost plus tax</returns>
        public void applyTax(Good good)
        {
            // Sales Tax anything that's not book, food, or medical at 10%
            List<string> nonTaxTypes = new List<string> { "Book", "Food", "Medical" };
            if (!nonTaxTypes.Contains(good.Type, StringComparer.OrdinalIgnoreCase)) {
                good.SalesTax += good.Cost * 0.10;
            }
            // Tax import goods at 5%
            if (good.Import)
            {
                good.SalesTax += good.Cost * 0.05;
            }
            // Round to the nearest .05
            good.SalesTax = Math.Ceiling(good.SalesTax * 20) / 20;
            good.Cost += good.SalesTax;
        }

        /// <summary>
        /// Print the receipt
        /// </summary>
        /// <returns>The total receipt</returns>
        public void printReceipt(Good good)
        {
            if (good.Import)
            {
                Console.WriteLine($"    1 imported {good.Name}: {String.Format("{0:0.00}", good.Cost)}");
            }
            else
            {
                Console.WriteLine($"    1 {good.Name}: {String.Format("{0:0.00}", good.Cost)}");
            }
        }
    }
}
