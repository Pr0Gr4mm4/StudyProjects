using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KledingWinkelLib.Objects
{
    public class Customer : Shipping
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //public string Shipping { get; set; }

        public Customer(string firstname, string lastname, Shipping shipaddress) 
            : base(shipaddress.Address,shipaddress.HouseNumber,shipaddress.City,shipaddress.Country,shipaddress.Zipcode)
        {
            firstName = firstname;
            lastName = lastname;
        }

        public Shipping Shipping
        {
            get { return new Shipping(Address,HouseNumber, City, Country, Zipcode); }
            set
            {
                Address = value.Address;
                HouseNumber = value.HouseNumber;
                City = value.City;
                Country = value.Country;
                Zipcode = value.Zipcode;
            }
        }

        /// <summary>
        /// Customer ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Customer name: {0} {1} \r\nCustomer address: {2}", firstName, lastName,Shipping.ToString());
        }

        /// <summary>
        /// Gets all the data related to the selected Customer Object
        /// </summary>
        public Dictionary<string, string> GetData
        {
            get
            {
                Dictionary<string, string> returnData = new Dictionary<string, string>();
                returnData.Add("Name",string.Format("{0} {1}",firstName,lastName));
                returnData.Add("StreetName",Shipping.Address);
                returnData.Add("StreetNumber",Shipping.HouseNumber.ToString());
                returnData.Add("City",Shipping.City);
                returnData.Add("Country",Shipping.Country);
                returnData.Add("ZippCode",Shipping.Zipcode);
                return returnData;
            }
        }
    }
}
