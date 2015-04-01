using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KledingWinkelLib.Objects
{
    public class Shipping
    {
        public string Address { get; set; }
        public int HouseNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }


        public Shipping(string _address, int _houseNumber, string _city, string _country, string _zipcode)
        {
            Address = _address;
            HouseNumber = _houseNumber;
            City = _city;
            Country = _country;
            Zipcode = _zipcode;
        }

        /// <summary>
        /// Shipping tostring method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Address: {0} {1}\r\nCity: {2} \r\nCountry: {3} \r\nZipcode: {4}", Address,HouseNumber, City, Country, Zipcode);
        }
    }
}
