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
            : base(shipaddress.Address,shipaddress.City,shipaddress.Country,shipaddress.Zipcode)
        {
            firstName = firstname;
            lastName = lastname;
        }

        public Shipping Shipping
        {
            get { return new Shipping(Address, City, Country, Zipcode); }
            set
            {
                Address = value.Address;
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

    }
}
