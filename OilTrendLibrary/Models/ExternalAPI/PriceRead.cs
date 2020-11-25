using System;
using System.Collections.Generic;
using System.Text;

namespace OilTrendLibrary.Models.ExternalAPI
{
	public class PriceRead
	{

		public DateTime Date { get; set; }
		public decimal Price { get; set; }

		public PriceRead()
		{

		}

		public PriceRead(DateTime date, decimal price)
		{
			this.Date = date;
			this.Price = price;
		}

	}
}
