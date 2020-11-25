using OilTrendLibrary.Models.ExternalAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OilTrendLibrary.Business
{
	public static class OilTrendManager
	{

		public static async Task<List<PriceRead>> GetOilPriceTrend(string url, DateTime dateFrom, DateTime dateTo)
		{
			try
			{
				HttpClient http = new HttpClient();
				var data = await http.GetAsync(url).Result.Content.ReadAsStringAsync();
				return JsonSerializer.Deserialize<List<PriceRead>>(data).Where(x => x.Date >= dateFrom && x.Date <= dateTo).ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
