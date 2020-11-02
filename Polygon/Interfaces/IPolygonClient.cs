using System.Net.Http;
using System.Threading.Tasks;

namespace Polygon
{
	public interface IPolygonClient
	{
		Crypto Crypto { get; }
		Forex Forex { get; }
		Reference References { get; }
		IStock Stocks { get; }
		Task<T> MakeRequestAsync<T>(string url);
		Task<T> MakePostRequestAsync<T>(T body, string url, HttpMethod method = null);
		Task<T> MakePutRequestAsync<T>(T body, string url, HttpMethod method = null);
		Task<T> MakeRequestAsync<T>(T body, string url, HttpMethod method = null);
	}
}
