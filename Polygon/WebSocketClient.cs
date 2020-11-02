using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net.WebSockets;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Polygon
{
	public class WebSocketClient
	{
		private readonly string _baseUrl;
		private readonly ConcurrentDictionary<string, ClientWebSocket> _webSockets = new ConcurrentDictionary<string, ClientWebSocket>();

		public WebSocketClient(string baseUrl = null)
		{
			_baseUrl = baseUrl ?? "wss://socket.polygon.io/";
		}

		static WebSocketClient()
		{
			var options = ((JsonSerializerOptions)typeof(JsonSerializerOptions).GetField("s_defaultOptions", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null));
			options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
			options.PropertyNameCaseInsensitive = true;
			options.IgnoreNullValues = true;
			var t = new WebSocketClient("Asdfafsd");
		}

		public async Task StartListeningAsync(string resource, Action<string> callbackAction, CancellationToken cancellationToken = default)
		{
			if (_webSockets.ContainsKey(resource)) return;
			var webSocket = new ClientWebSocket();
			await webSocket.ConnectAsync(new Uri(_baseUrl + resource), cancellationToken).ConfigureAwait(false);
			_webSockets.TryAdd(resource, webSocket);
			var buffer = new ArraySegment<byte>(new byte[8192]);
			_ = Task.Factory.StartNew(async () =>
			  {
				  while (!cancellationToken.IsCancellationRequested)
				  {
					  // one message
					  using var ms = new MemoryStream();
					  while (true)
					  {
						  var receiveResult = await webSocket.ReceiveAsync(buffer, cancellationToken).ConfigureAwait(false);
						  await ms.WriteAsync(buffer.Array, buffer.Offset, receiveResult.Count).ConfigureAwait(false);
						  if (receiveResult.EndOfMessage)
						  {
							  ms.Position = 0;
							  using var sr = new StreamReader(ms);
							  callbackAction(await sr.ReadToEndAsync().ConfigureAwait(false));
							  break;
						  }
					  }
				  }
			  }, cancellationToken).ConfigureAwait(false);

		}

		public async Task SendAsync<T>(string resource, T value, CancellationToken cancellationToken = default)
		{
			var closeImmediately = false;
			if (!_webSockets.TryGetValue(resource, out var webSocket))
			{
				await StartListeningAsync(resource, null, cancellationToken).ConfigureAwait(false);
				_webSockets.TryGetValue(resource, out webSocket);
				closeImmediately = true;
			}

			await webSocket.SendAsync(new ArraySegment<byte>(JsonSerializer.SerializeToUtf8Bytes(value)),
				WebSocketMessageType.Text,
				true,
				cancellationToken).ConfigureAwait(false);

			if (closeImmediately) await StopListeningAsync(resource, cancellationToken).ConfigureAwait(false);
		}

		public async Task StopListeningAsync(string resource, CancellationToken cancellationToken = default)
		{
			if (_webSockets.TryGetValue(resource, out var webSocket))
			{
				await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, cancellationToken).ConfigureAwait(false);
				_webSockets.TryRemove(resource, out var _);
			}
		}

	}
}
