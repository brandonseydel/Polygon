using System;
using System.Runtime.Serialization;

namespace Polygon
{
	[Serializable]
	internal class PolygonException : Exception
	{
		public PolygonException()
		{
		}

		public PolygonException(string message) : base(message)
		{
		}

		public PolygonException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected PolygonException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}