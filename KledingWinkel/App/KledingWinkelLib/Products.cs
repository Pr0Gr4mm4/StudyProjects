using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KledingWinkelLib.KledingTypes.Algemeen;
using KledingWinkelLib.KledingTypes.Jas;

namespace KledingWinkelLib.Products
{
    public class Tshirt : KledingStuk
    {
        public string text { get; set; }
        public Tshirt(string Text, int _id, string imageurl, decimal _price, KledingSize _size, KledingType kledingtype, Merk _merk, int Amount, bool isForSale)
            : base(_id, imageurl, _price, _size, kledingtype,_merk,Amount,isForSale)
        {
            text = Text;
        }
        public override string ToString()
        {
            return string.Format("Tshirt informatie: \r\nText: {0} \r\nKledingstuk informatie: {1}",this.text,base.ToString());
        }

        public Dictionary<string,string> GetData
        {
            get
            {
                Dictionary<string, string> dataDict = new Dictionary<string, string>();
                dataDict.Add("KledingStukID", this.id.ToString());
                dataDict.Add("Text", this.text);
                dataDict.Add("Price", this.price.ToString());
                dataDict.Add("Amount", amount.ToString());
                dataDict.Add("ImageUrl", this.imageUrl);
                dataDict.Add("Size", this.size.ToString());
                dataDict.Add("Merk", this.merk.ToString());
                //dataDict.Add("JasType", "NULL");
                dataDict.Add("IsForSale",this.IsForSale.ToString());

                return dataDict;
            }
        }
    }
    public class Jas : KledingStuk
    {
        public KledingWinkelLib.KledingTypes.Jas.JasType jastype { get; set; }
        public Jas(KledingWinkelLib.KledingTypes.Jas.JasType _jastype, Merk _merk, int _id, string imageurl, decimal _price, KledingSize _size, KledingType kledingtype, int Amount, bool isForSale) 
            : base(_id,imageurl,_price,_size,kledingtype,_merk,Amount,isForSale)
        {
            jastype = _jastype;
        }

        public override string ToString()
        {
            return string.Format("Jas informatie: \r\n Jastype: {0} \r\nKledingstuk informatie: {1}", jastype, base.ToString());
        }

        public Dictionary<string, string> GetData
        {
            get
            {
                Dictionary<string, string> dataDict = new Dictionary<string, string>();
                dataDict.Add("KledingStukID", this.id.ToString());
                //dataDict.Add("Text", null);
                dataDict.Add("Price", this.price.ToString());
                dataDict.Add("Amount", amount.ToString());
                dataDict.Add("ImageUrl", this.imageUrl);
                dataDict.Add("Size", this.size.ToString());
                dataDict.Add("Merk", this.merk.ToString());
                dataDict.Add("JasType", this.jastype.ToString());
                dataDict.Add("IsForSale", this.IsForSale.ToString());

                return dataDict;
            }
        }
    }
    public class KledingStuk
    {
        #region Base values
        public int id { get; set; }
        public string imageUrl { get; set; }
        public decimal price { get; set; }
        public KledingSize size { get; set; }
        public KledingType kledingType { get; set; }
        public KledingWinkelLib.KledingTypes.Algemeen.Merk merk { get; set; }
        public int amount { get; set; }
        public bool IsForSale { get; set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id">Kledingstuk ID</param>
        /// <param name="imageurl">Kleding image url</param>
        /// <param name="_price">Kleding prijs</param>
        /// <param name="_size">Kleding grootte</param>
        /// <param name="kledingtype">Kleeding type</param>
        public KledingStuk(int _id, string imageurl, decimal _price, KledingSize _size, KledingType kledingtype, Merk _merk ,int _amount, bool isForSale)
        {
            id = _id;
            imageUrl = imageurl;
            price = _price;
            size = _size;
            kledingType = kledingtype;
            amount = _amount;
            IsForSale = isForSale;
            merk = _merk;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id">Kledingstuk ID</param>
        /// <param name="imageurl">Kleding image url</param>
        /// <param name="_price">Kleding prijs</param>
        /// <param name="_size">Kleding grootte</param>
        /// <param name="kledingtype">Kleeding type</param>
        public KledingStuk(int _id, string imageurl, decimal _price, string _size, string _kledingtype)
        {
            id = _id;
            imageUrl = imageurl;
            price = _price;
            size = (KledingSize)Enum.Parse(typeof(KledingSize), _size.ToUpper());
            kledingType = (KledingType)Enum.Parse(typeof(KledingType), _kledingtype.ToUpper());
        }
        
        public override string ToString()
        {
            return string.Format("ID: {0} \r\nImageurl: {1} \r\nPrijs: {2} \r\nSize: {3} \r\nKledingtype: {4} \r\nkledingmerk: {5}",id,imageUrl,price,size,kledingType.ToString(),merk.ToString());
        }
    }
}
