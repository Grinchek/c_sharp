using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _12_Events
{
    internal class Trader
    {
        public double PriceForBy { get; set; }
        public double PriceForSale { get; set; }
        public string Name { get; set; }
        private double currency;
        public double Currency
        {
            get { return currency; }
            set { currency = (value >0) ? value :throw new Exception($"{Name} has spend all dollars;"); }
        }
        private double capital;

		public double Capital
		{
			get { return capital; }
			set { capital = (value>0)?value: throw new Exception($"{Name} has spend all hryvnias;"); }
		}

		public Trader()
		{
			Currency = 1;
			Capital = 1;
			PriceForBy = 1;
			PriceForSale = 1;
		}
        public Trader(string name,double capital,double priceForBy,double priceForSale)
        {
			Name = name;
            Currency = 1;
            Capital =capital;
			PriceForBy=priceForBy;
			PriceForSale=priceForSale;

        }

        public void Purchase(double price)
		{
			if (price <= PriceForBy&&Capital>=price)
			{
				Currency = Capital / price;
				Capital = Capital - (Currency * price);
				Console.WriteLine($"{Name} bying.Curency amount: {Math.Round(Currency, 2)}.Hryvnia amount: {Math.Round(Capital, 2)}");
			}

		}
		public void Sale(double price)
		{
			if(price>=PriceForSale&&Currency>=1)
			{
				Capital = capital+(Currency * price);
                Currency = Currency - (Capital / price);
                Console.WriteLine($"{Name} saling.Curency amount: {Math.Round(Currency,2)}.Hryvnia amount: {Math.Round(Capital,2)}");
				
            }
		}

	}
}
