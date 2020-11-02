using FluentAssertions;
using NUnit.Framework;
using Polygon.Enums;
using System;
using System.Threading.Tasks;

namespace Polygon.Tests
{
	public class Tests
	{
		private PolygonClient _client;

		[SetUp]
		public void Setup()
		{
			PolygonClient.Configure("U9lQRXCEfLp21pT2lhnLnhbYM0GSpcS3");
			this._client = new PolygonClient(new System.Net.Http.HttpClient());
		}

		[Test]
		public async Task GetSnapshotAsync()
		{

			var result = await _client.Stocks.GetSnapshotAsync("F");
		}

		[Test]
		public async Task GetSnapshotGainersLosersAsync()
		{

			var result = await _client.Stocks.GetSnapshotGainersLosersAsync(Direction.Gainers);
		}

		[Test]
		public async Task GetSnapshotsAsync()
		{

			var result = await _client.Stocks.GetSnapshotAsync(new[] { "F" });
		}

		[Test]
		public async Task ExchangesAsync()
		{

			var result = await _client.Stocks.GetExchangesAsync();
			result.Should().NotBeEmpty();
		}

		[Test]
		public async Task GetPreviousCloseAsync()
		{

			var result = await _client.Stocks.GetPreviousCloseAsync("F");
			result.Should().NotBeNull();
		}

		[Test]
		public async Task GetBarAggregatesAsync()
		{
			var result = await _client.Stocks.GetBarGroupedDailyAsync(Enums.Locale.US, Enums.Market.STOCKS, DateTime.Now.AddDays(-10));
			result.Should().NotBeNull();
		}

		[Test]
		public async Task GetHistoricTradesAsync()
		{
			var result = await _client.Stocks.GetHistoricTradesAsync("F", DateTime.Now.AddDays(-3));
			result.Should().NotBeNull();
		}

		[Test]
		public async Task GetHistoricTradesNBBOAsync()
		{
			var result = await _client.Stocks.GetHistoricQuotesNBBOAsync("F", DateTime.Now.AddDays(-3));
			result.Should().NotBeNull();
		}

		[Test]
		public async Task GetLastTradeAsync()
		{
			var result = await _client.Stocks.GetLastTradeAsync("F");
			result.Should().NotBeNull();
		}

		[Test]
		public async Task GetLastQuoteAsync()
		{
			var result = await _client.Stocks.GetLastQuoteAsync("F");
			result.Should().NotBeNull();
		}

		[Test]
		public async Task GetDailyOpenCloseAsync()
		{
			var result = await _client.Stocks.GetDailyOpenCloseAsync("F", DateTime.Now.AddDays(-3));
			result.Should().NotBeNull();
		}

		[Test]
		public async Task GetConditionMappingAsync()
		{
			var result = await _client.Stocks.GetConditionMappingAsync(TickType.Trades);
			result.Should().NotBeNull();
		}

	}
}
