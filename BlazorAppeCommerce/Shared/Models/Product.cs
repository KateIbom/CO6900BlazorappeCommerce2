using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppeCommerce.Shared.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        // The official name for the product that will 
        // be displayed to the customer on the website
        public string Name { get; set; }    
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public decimal SalePrice { get; set; }
        public decimal OfferPrice { get; set; }
        public double Weight { get; set; }
        public WeightUnits WeightUnit { get; set; }

        public int CurrentStock { get; set; }

        public int OrderedStock { get; set; }


    }
}
