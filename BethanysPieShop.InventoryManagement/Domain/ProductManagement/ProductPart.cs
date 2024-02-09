using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.InventoryManagement.Domain.ProductManagement
{
    public partial class Product
    {
        private void UpdateLowStock()
        {
            if (AmountInStock < 10) // for now a fixed value
            {
                IsBelowStockThreshold = true;
            }
        }

        private void Log(string message)
        {
            // this could be written to a file
            Console.WriteLine(message);
        }

        private string CreateSimpleProductRepresentation()
        {
            return $"Product {id} ({name})";
        }
    }
}
