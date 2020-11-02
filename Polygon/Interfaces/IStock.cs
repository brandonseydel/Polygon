using Polygon.Enums;
using Polygon.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Polygon
{
    public interface IStock
    {
        Task<AggResponse> GetBarAggregatesAsync(string ticker, DateTime from, DateTime to, PolygonTimeSpan timespan = PolygonTimeSpan.Day, int multiplier = 1, bool? unadjusted = null, string sort = null);
        Task<AggResponse> GetBarGroupedDailyAsync(Locale locale, Market market, DateTime toDate, bool? unadjusted = false);
        Task<IDictionary<string, string>> GetConditionMappingAsync(TickType trades);
        Task<StocksOpenClose> GetDailyOpenCloseAsync(string symbol, DateTime date);
        Task<IEnumerable<Exchange>> GetExchangesAsync();
        Task<TicksStocksNbboTickerDateGetResponse> GetHistoricQuotesNBBOAsync(string symbol, DateTime dateToRetrieve, int? limit = null, int? timestamp = null, int? timestampLimit = null, bool reverse = false);
        Task<TicksStocksTradesTickerDateGetResponse> GetHistoricTradesAsync(string symbol, DateTime dateToRetrieve, int? limit = null, int? timestamp = null, int? timestampLimit = null, bool reverse = false);
        Task<LastQuoteStocksSymbolGetResponse> GetLastQuoteAsync(string symbol);
        Task<LastStocksSymbolGetResponse> GetLastTradeAsync(string symbol);
        Task<Aggv2> GetPreviousCloseAsync(string sybmol, bool unadjusted = false);
        Task<SnapshotLocaleUsMarketsStocksDirectionGetResponse> GetSnapshotAsync(params string[] symbols);
        Task<SnapshotLocaleUsMarketsStocksTickersTickerGetResponse> GetSnapshotAsync(string symbol);
        Task<SnapshotLocaleUsMarketsStocksDirectionGetResponse> GetSnapshotGainersLosersAsync(Direction direction);
    }
}