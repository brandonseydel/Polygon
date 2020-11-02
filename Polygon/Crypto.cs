namespace Polygon
{
	public class Crypto
	{
		private readonly string _resource = "";
		private readonly IPolygonClient _client;
		public Crypto(IPolygonClient client) { _client = client; }
	}
}
