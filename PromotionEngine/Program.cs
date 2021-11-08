using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total order quantity");
            int num = Convert.ToInt32(Console.ReadLine());
            List<Product> lstProduct = new List<Product>();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter product\nA\nB\nC\nD");
                String productId = Convert.ToString(Console.ReadLine());
                Product pr = new Product(productId);
                lstProduct.Add(pr);
            }
            int totalPrice = Product.returnTotalPrice(lstProduct);
            Console.WriteLine("Total Amount:" + totalPrice);
            Console.ReadKey();
        }
    }
}
