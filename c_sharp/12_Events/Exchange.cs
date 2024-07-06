using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _12_Events
{
    public delegate void OnTradeDelegate(double price);

    internal class Exchange
    {
        Trader ivan = new Trader("Ivan", 3000, 42, 43);
        Trader stepan = new Trader("Stepan", 3500, 41, 42);
        Trader evhen = new Trader("Evhen", 4000, 41, 42);
        public event OnTradeDelegate OnTradeEvent;


        private double usd;

		public  double Usd
		{
			get { return Math.Round(usd,3); }
			set { usd = (value>=39.5&&value<=44.1)?value: 40.01; }
		}
		private int move;

		public int Move
		{
			get { return move; }
			set { move = value; }
		}

        public Exchange()
		{
			Usd = 40;
        }
		public double ExchangeLife()
		{
            Random random = new Random();
			move=random.Next(2);
			if (move == 0)
			{ Usd-=random.NextDouble(); }
			else { Usd+= random.NextDouble(); }
			return Math.Round(Usd,2);
        }
		public void Subscribing()
		{
			OnTradeEvent = ivan.Purchase;
			OnTradeEvent += ivan.Sale;
			OnTradeEvent += stepan.Purchase;
			OnTradeEvent += stepan.Sale;
			OnTradeEvent += evhen.Purchase;
			OnTradeEvent += evhen.Sale;
		}
		public void ExchangeSession()
		{
			for (int i = 0; i < 100; i++)
			{
				ExchangeLife();
				try 
				{
					OnTradeEvent?.Invoke(ExchangeLife());
				}
				catch(Exception e)
				{
                    Console.WriteLine(ExchangeLife());
                }


                Thread.Sleep(1000);
			}
		}

    }
}
