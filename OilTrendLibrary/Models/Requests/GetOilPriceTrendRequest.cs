using System;
using System.Collections.Generic;
using System.Text;

namespace OilTrendLibrary.Models.Requests
{
	public class GetOilPriceTrendRequest
	{

		public int id { get; set; }
		public string jsonrpc { get; set; }
		public string method { get; set; }
		public DateParameters @params { get; set; }

	}
}
