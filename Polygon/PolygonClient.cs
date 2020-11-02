using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Polygon
{
	public class PolygonClient : IPolygonClient
	{
		private static JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions
		{
			IgnoreNullValues = true,
			PropertyNameCaseInsensitive = false,
			WriteIndented = false,
			IgnoreReadOnlyProperties = true
		};

		private readonly ILogger<PolygonClient> _logger;
		private readonly HttpClient _httpClient;
		private static string s_apiKey;
		private Crypto _crypto;
		private Forex _forex;
		private Reference _references;
		private IStock _stocks;

		public PolygonClient(
			HttpClient httpClient,
			ILogger<PolygonClient> logger = null,
			string apiKey = null)

		{
			_httpClient = httpClient;
			_logger = logger;
			s_apiKey = apiKey ?? s_apiKey;
			httpClient.BaseAddress = new Uri($@"https://api.polygon.io/");
		}

		public Task<T> MakePutRequestAsync<T>(T body, string url, HttpMethod method = null) { return MakeRequestAsync<T>(body, url, HttpMethod.Put); }
		public Task<T> MakePostRequestAsync<T>(T body, string url, HttpMethod method = null) { return MakeRequestAsync<T>(body, url, HttpMethod.Post); }

		public async Task<T> MakeRequestAsync<T>(T body, string url, HttpMethod method = null)
		{
			url = QueryHelpers.AddQueryString(url, "apiKey", s_apiKey);

			method ??= HttpMethod.Post;
			_logger?.LogInformation($"Sending Request at {DateTime.UtcNow}");
			var result = await (method == HttpMethod.Post ?
			 _httpClient.PostAsJsonAsync(url, body) :
			_httpClient.PutAsJsonAsync(url, body)).ConfigureAwait(false);
			_logger?.LogInformation($"Finished sending request at {DateTime.UtcNow}");

			if (!result.IsSuccessStatusCode)
			{
				throw new PolygonException($"Status Code: {result.StatusCode} Response: {await result.Content.ReadAsStringAsync().ConfigureAwait(false)}");
			}

			return await result.Content.ReadFromJsonAsync<T>(JsonSerializerOptions);
		}

		public async Task<T> MakeRequestAsync<T>(string url)
		{
			url = QueryHelpers.AddQueryString(url, "apiKey", s_apiKey);
			_logger?.LogInformation($"Sending Request at {DateTime.UtcNow}");
			var result = await _httpClient.GetAsync(url);
			_logger?.LogInformation($"Finished sending request at {DateTime.UtcNow}");

			if (!result.IsSuccessStatusCode)
			{
				throw new PolygonException($"Status Code: {result.StatusCode} Response: {await result.Content.ReadAsStringAsync().ConfigureAwait(false)}");
			}

			return await result.Content.ReadFromJsonAsync<T>(JsonSerializerOptions);
		}

		public Crypto Crypto
		{
			get
			{
				if (_crypto == null)
				{
					_crypto = new Crypto(this);
				}
				return _crypto;
			}
		}

		public Forex Forex
		{
			get
			{
				if (_forex == null)
				{
					_forex = new Forex(this);
				}
				return _forex;
			}
		}

		public Reference References
		{
			get
			{
				if (_references == null)
				{
					_references = new Reference(this);
				}
				return _references;
			}
		}

		public Stock Stocks
		{
			get
			{
				if (_stocks == null)
				{
					_stocks = new Stock(this);
				}
				return _stocks;
			}
		}



		static PolygonClient()
		{
			var options = ((JsonSerializerOptions)typeof(JsonSerializerOptions).GetField("s_defaultOptions", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null));
			options.PropertyNameCaseInsensitive = false;
			options.IgnoreNullValues = true;
			options.Converters.Add(new JsonStringEnumConverter());
		}

		public static void Configure(string apiKey)
		{
			s_apiKey = apiKey;
		}
	}
}
