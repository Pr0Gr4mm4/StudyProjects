using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KledingWinkelLib;
using KledingWinkelLib.OrderManager;
using KledingWinkelLib.ProductLists;

namespace KledingWinkelFinal
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
        internal static DBHandler databaseHandler = new DBHandler(@"Server=localhost\SYNSERNET;Database=KledingWinkel;User ID=KledingWinkelAppl; Password=kledingwinkel");

        internal static List<int> ActiveMdiChildTree = new List<int>();
        internal static int ActiveMdiChildID = 0;

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
