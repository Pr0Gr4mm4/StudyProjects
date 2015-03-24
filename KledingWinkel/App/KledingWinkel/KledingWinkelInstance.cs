using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KledingWinkelLib;
using KledingWinkelLib.OrderManager;
using KledingWinkelLib.ProductLists;

namespace KledingWinkelApp
{
    /// <summary>
    /// Initialized once when the program starts. 
    /// Acts as an internal database for all existing objects.
    /// </summary>
    internal static class KledingWinkelInstance
    {
        internal static CustomerList customerList = new CustomerList();
        internal static OrderList orderList = new OrderList();
        internal static TshirtList tshirtList = new TshirtList();
        internal static JasList jasList= new JasList();

        /// <summary>
        /// Generates a new product ID by calculating the amount of existing products and returning that number + 1.
        /// </summary>
        internal static int GenerateProductID
        {
            get
            {
                return ((tshirtList.Count() + jasList.Count()) + 1);
            }
        }
    }
}
