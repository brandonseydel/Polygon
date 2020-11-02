using Polygon.Enums;
using Polygon.Helpers;
using Polygon.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Polygon
{
    public class Stock : IStock
    {
        private readonly string _resource = "";
        private readonly IPolygonClient _client;

        public Stock(IPolygonClient client)
        {
            _client = client;
        }

        public Task<IEnumerable<Models.Exchange>> GetExchangesAsync() => _client.MakeRequestAsync<IEnumerable<Models.Exchange>>($"/v1/meta/exchanges");

        public Task<Aggv2> GetPreviousCloseAsync(string sybmol, bool unadjusted = false) => _client.MakeRequestAsync<Aggv2>($"/v2/aggs/ticker/{sybmol}/prev?unadjusted={unadjusted}");

        public Task<AggResponse> GetBarAggregatesAsync(string ticker, DateTime from, DateTime to, PolygonTimeSpan timespan = PolygonTimeSpan.Day, int multiplier = 1, bool? unadjusted = null, string sort = null) => _client.MakeRequestAsync<AggResponse>($"/v2/aggs/ticker/{ticker}/range/{multiplier}/{Enum.GetName(typeof(PolygonTimeSpan), timespan)?.ToLower()}/{from:yyyy-MM-dd}/{to:yyyy-MM-dd}{new { unadjusted, sort }.ToQueryString()}");

        public Task<AggResponse> GetBarGroupedDailyAsync(Locale locale, Market market, DateTime toDate, bool? unadjusted = false) => _client.MakeRequestAsync<AggResponse>($"/v2/aggs/grouped/locale/{Enum.GetName(typeof(Locale), locale)}/market/{Enum.GetName(typeof(Market), market)}/{toDate:yyyy-MM-dd}?unadjusted={unadjusted}");

        public Task<TicksStocksTradesTickerDateGetResponse> GetHistoricTradesAsync(string symbol, DateTime dateToRetrieve, int? limit = null, int? timestamp = null, int? timestampLimit = null, bool reverse = false) => _client.MakeRequestAsync<TicksStocksTradesTickerDateGetResponse>($"/v2/ticks/stocks/trades/{symbol}/{dateToRetrieve:yyyy-MM-dd}{new { limit, timestamp, timestampLimit, reverse }.ToQueryString()}");

        public Task<TicksStocksNbboTickerDateGetResponse> GetHistoricQuotesNBBOAsync(string symbol, DateTime dateToRetrieve, int? limit = null, int? timestamp = null, int? timestampLimit = null, bool reverse = false) => _client.MakeRequestAsync<TicksStocksNbboTickerDateGetResponse>($"/v2/ticks/stocks/nbbo/{symbol}/{dateToRetrieve:yyyy-MM-dd}{new { limit, timestamp, timestampLimit, reverse }.ToQueryString()}");

        public Task<LastStocksSymbolGetResponse> GetLastTradeAsync(string symbol) => _client.MakeRequestAsync<LastStocksSymbolGetResponse>($"/v1/last/stocks/{symbol}");

        public Task<LastQuoteStocksSymbolGetResponse> GetLastQuoteAsync(string symbol) => _client.MakeRequestAsync<LastQuoteStocksSymbolGetResponse>($"/v1/last_quote/stocks/{symbol}");

        public Task<StocksOpenClose> GetDailyOpenCloseAsync(string symbol, DateTime date) => _client.MakeRequestAsync<StocksOpenClose>($"/v1/open-close/{symbol}/{date:yyyy-MM-dd}");

        public Task<IDictionary<string, string>> GetConditionMappingAsync(TickType trades) => _client.MakeRequestAsync<IDictionary<string, string>>($"/v1/meta/conditions/{Enum.GetName(typeof(TickType), trades)?.ToLower()}");


        public async Task<SnapshotLocaleUsMarketsStocksDirectionGetResponse> GetSnapshotAsync(params string[] symbols) => await _client.MakeRequestAsync<SnapshotLocaleUsMarketsStocksDirectionGetResponse>($"v2/snapshot/locale/us/markets/stocks/tickers?tickers={string.Join(",", symbols)}").ConfigureAwait(false);

        public async Task<SnapshotLocaleUsMarketsStocksTickersTickerGetResponse> GetSnapshotAsync(string symbol) => await _client.MakeRequestAsync<SnapshotLocaleUsMarketsStocksTickersTickerGetResponse>($"v2/snapshot/locale/us/markets/stocks/tickers/{symbol}").ConfigureAwait(false);

        public async Task<SnapshotLocaleUsMarketsStocksDirectionGetResponse> GetSnapshotGainersLosersAsync(Direction direction) => await _client.MakeRequestAsync<SnapshotLocaleUsMarketsStocksDirectionGetResponse>($"/v2/snapshot/locale/us/markets/stocks/{Enum.GetName(typeof(Direction), direction).ToLower()}").ConfigureAwait(false);




    }
}
