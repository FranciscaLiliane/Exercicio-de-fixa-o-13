using System;
using System.Globalization;

namespace Exercício_13.Entites
{
    class UsedProduct : Product
    {
        public DateTime ManufactreDate { get; set; }
        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufactreDate) : base(name, price)
        {
            ManufactreDate = manufactreDate;
        }
        public override string priceTag()
        {
            return Name 
                +" (used) $ "
                + Price.ToString("F2",CultureInfo.InvariantCulture) 
                +" (Manufacture date: " 
                + ManufactreDate.ToString("dd/MM/yyyy")
                +")";
        }
    }
}
