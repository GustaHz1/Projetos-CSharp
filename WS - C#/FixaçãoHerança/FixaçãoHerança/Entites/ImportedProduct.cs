using System;
using System.Globalization;

namespace FixaçãoHerança.Entites
{
    class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }
        public ImportedProduct(double customsFee, string name, double price)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
        }

        public double TotalPrice()
        {
            return Price * CustomsFee;
        }
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
