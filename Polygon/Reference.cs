using Polygon.Helpers;
using Polygon.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Polygon
{
	public class Reference
	{
		private readonly string _resource = "";
		private readonly IPolygonClient _client;
		internal Reference(IPolygonClient client) { _client = client; }

		/// <summary>
		/// Calls the /v2/reference/types endpoint
		/// </summary>
		/// <param name="sort"></param>
		/// <param name="type"></param>
		/// <param name="market"></param>
		/// <param name="locale"></param>
		/// <param name="search"></param>
		/// <param name="perpage"></param>
		/// <param name="page"></param>
		/// <param name="active"></param>
		/// <returns></returns>
		public Task<ReferenceTickersGetResponse> GetTickers(string sort, string market, string locale, string search, string type = null, int? perpage = null, int? page = null, bool? active = null)
		{
			return _client.MakeRequestAsync<ReferenceTickersGetResponse>(@$"/v2/reference/tickers{new
			{
				sort,
				type,
				market,
				locale,
				search,
				perpage,
				page,
				active
			}.ToQueryString()}");
		}

		public Task GetMarketMonthInfoAsync(string token, DateTime estDate)
		{
			return _client.MakeRequestAsync<MarketStatus>($@"/v1/marketstatus/now");
		}

		public Task<MarketStatus> GetCurrentMarketStatusAsync()
		{
			return _client.MakeRequestAsync<MarketStatus>($@"/v1/marketstatus/now");
		}

		public Task<IEnumerable<MarketHoliday>> GetMarketHolidaysAsync()
		{
			return _client.MakeRequestAsync<IEnumerable<MarketHoliday>>($@"/v1/marketstatus/upcoming");
		}
	}
}
