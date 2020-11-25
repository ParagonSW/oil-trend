using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OilTrendLibrary.Models.ExternalAPI;
using OilTrendLibrary.Models.Requests;
using OilTrendLibrary.Models.Responses;

namespace OilTrendAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OilTrendController : ControllerBase
	{

		private readonly IConfiguration _config;

		public OilTrendController(IConfiguration config)
		{
			this._config = config;
		}

		[HttpGet]
		public async Task<ActionResult<GetOilPriceTrendResponse>> GetOilPriceTrend([FromBody] string content)
		{
			try
			{
				var url = this._config.GetValue<string>("ApiURL");
				var request = JsonSerializer.Deserialize<GetOilPriceTrendRequest>(content);
				switch (request.method)
				{
					case "GetOilPriceTrend":
						var reads = await OilTrendLibrary.Business.OilTrendManager.GetOilPriceTrend(url: url,
																									dateFrom: request.@params.startDateISO8601,
																									dateTo: request.@params.endDateISO8601);
						return new GetOilPriceTrendResponse(id: request.id, jsonrpc: request.jsonrpc, result: reads);
					default:
						return StatusCode(400);
				}
			}
			catch(Exception)
			{
				return StatusCode(400);
			}
		}

	}
}
