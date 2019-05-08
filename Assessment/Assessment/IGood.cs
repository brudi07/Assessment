using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Assessment
{
    public interface IGood
    {
        // properties
        string Name { get; set; }
        string Type { get; set; }
        double Cost { get; set; }
        double SalesTax { get; set; }
        bool Import { get; set; }
    }
}
