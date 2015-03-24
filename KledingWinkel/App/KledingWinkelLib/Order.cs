using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KledingWinkelLib.Products;

namespace KledingWinkelLib.OrderManager
{
    public class Order
    {
        public int orderID { get; set; }
        public DateTime orderDate { get; set; }
        public int CustomerID { get; private set; }
        public Order(int customerid)
        {
            CustomerID = customerid;
        }

        /// <summary>
        /// FORMAT: Tshirt, amount
        /// </summary>
        public Dictionary<Tshirt, int> orderedTshirts { get; set; }
        /// <summary>
        /// FORMAT: Jas, amount
        /// </summary>
        public Dictionary<Jas,int > orderedJassen { get; set; }

        /// <summary>
        /// Gets the total price of all ordered items together
        /// </summary>
        public decimal GetTotalPrice
        {
            get 
            {
                decimal returnvalue = 0.00m;

                if(orderedTshirts != null)
                {
                    foreach(Tshirt tshirt in orderedTshirts.Keys)
                    {
                        returnvalue += (tshirt.price * orderedTshirts[tshirt]);
                    }
                }
                if(orderedJassen != null)
                {
                    foreach(Jas jas in orderedJassen.Keys)
                    {
                        returnvalue += (jas.price * orderedJassen[jas]);
                    }
                }

                return returnvalue;
            }
        }

        public Dictionary<string,string> GetData
        {
            get
            {
                Dictionary<string, string> OrderData = new Dictionary<string, string>();
                OrderData.Add("CustomerID",CustomerID.ToString());
                OrderData.Add("OrderID",orderID.ToString());

                foreach(Tshirt t in orderedTshirts.Keys)
                {
                    OrderData.Add("KledingStukID",t.id.ToString());
                    OrderData.Add("OrderedAmount", t.amount.ToString());
                }

                foreach (Jas j in orderedJassen.Keys)
                {
                    OrderData.Add("KledingStukID", j.id.ToString());
                    OrderData.Add("OrderedAmount", j.amount.ToString());
                }
                
                return OrderData;
            }
        }



        // TODO
        public bool AddProductToOrder(int id, int amount)
        {
            bool flag = false;




            return flag;
        }


        


    }
}
