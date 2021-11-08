using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
   public class Product
    {
        public Product(string productID)
        {
            productId = productID;
        }
        public string productId { get; set; }

        public double productPrice { get; set; }

        public static int returnTotalPrice(List<Product> lstProduct)
        {
            int productAprice = 50;
            int productBprice = 30;
            int productCprice = 20;
            int productDprice = 15;
            int countA = 0, countB = 0, countC = 0, countD = 0;
            foreach (var item in lstProduct)
            {
                if (item.productId.Equals("a", StringComparison.CurrentCultureIgnoreCase))
                {
                    countA++;
                }
                else if (item.productId.Equals("b", StringComparison.CurrentCultureIgnoreCase))
                {
                    countB++;
                }
                else if (item.productId.Equals("c", StringComparison.CurrentCultureIgnoreCase))
                {
                    countC++;
                }
                else if (item.productId.Equals("d", StringComparison.CurrentCultureIgnoreCase))
                {
                    countD++;
                }
            }
            int countCDprice = 0;
            if(countC > 0 && countD > 0)
            {
                if (countC- countD == 0)
                {
                    countCDprice = 30 * countD;
                }
                else if (countC > countD) {
                    countCDprice = (countC - countD) * productCprice + 30 * countD;
                }
                else if (countD > countC)
                {
                    countCDprice = (countD - countC) * productDprice + 30 * countC;
                }
            }
            else
            {
                countCDprice = countC * productCprice + countD * productDprice;
            }
            int price = (countA / 3) * 130 + (countA % 3 * productAprice) + (countB / 2) * 45 + (countB % 2 * productBprice) + countCDprice;

            return price;
        }
    }
}
