using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
namespace EnvironmentAssessment.Common.VimApi
{
	internal class HttpHeaderInterceptor : IClientMessageInspector
	{
		private readonly string _headerName;
		private readonly Func<string> _headerValueProvider;
		public HttpHeaderInterceptor(string headerName, Func<string> headerValueProvider)
		{
			this._headerName = headerName;
			this._headerValueProvider = headerValueProvider;
		}
		public object BeforeSendRequest(ref Message request, IClientChannel channel)
		{
			string value = this._headerValueProvider();
			object obj;
			if (request.Properties.TryGetValue(HttpRequestMessageProperty.Name, out obj))
			{
				((HttpRequestMessageProperty)obj).Headers[this._headerName] = value;
			}
			else
			{
				HttpRequestMessageProperty httpRequestMessageProperty = new HttpRequestMessageProperty();
				httpRequestMessageProperty.Headers[this._headerName] = value;
				request.Properties.Add(HttpRequestMessageProperty.Name, httpRequestMessageProperty);
			}
			return null;
		}
		public void AfterReceiveReply(ref Message reply, object correlationState)
		{
		}
	}
}
