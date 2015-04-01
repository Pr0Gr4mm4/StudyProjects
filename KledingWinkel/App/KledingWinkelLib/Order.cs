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

        /// <summary>
        /// Creates a new order for the customer with the given ID.
        /// </summary>
        /// <param name="customerid">The customer ID</param>
        public Order(int customerid)
        {
            CustomerID = customerid;
            orderedTshirts = new Dictionary<Tshirt, int>();
            orderedJassen = new Dictionary<Jas, int>();
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

        // BUG: GetData Overwrites the ids of the given list. 

        /// <summary>
        /// Gets all the data in relation the the selected Order Object in dictionary string format.
        /// </summary>
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

        /// <summary>
        /// Adds a product of the shop to the order with the given amount
        /// </summary>
        /// <param name="o">The object to add (either Tshirt or Jas(coat))</param>
        /// <param name="amount">The amount of the product to be ordered</param>
        /// <returns>Whether successfull or not</returns>
        public bool AddProductToOrder(Object o, int amount)
        {
            bool flag = false;
            if(o.GetType() == typeof(Tshirt))
            {
                orderedTshirts.Add((Tshirt)o, amount);
                flag = true;
            }
            else if (o.GetType() == typeof(Jas))
            {
                orderedJassen.Add((Jas)o, amount);
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}
