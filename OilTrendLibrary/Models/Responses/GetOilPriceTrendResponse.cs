using OilTrendLibrary.Models.ExternalAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace OilTrendLibrary.Models.Responses
{
	public class GetOilPriceTrendResponse
	{

		public int id { get; set; }
		public string jsonrpc { get; set; }
		public List<PriceRead> result { get; set; }

		public GetOilPriceTrendResponse(int id, string jsonrpc, List<PriceRead> result)
		{
			this.id = id;
			this.jsonrpc = jsonrpc;
			this.result = result;
		}

	}
}
