using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
namespace EnvironmentAssessment.Common.VimApi
{
	internal class UserAgentBehavior : IEndpointBehavior
	{
		private readonly string _userAgent;
		private string UserAgent
		{
			get
			{
				return this._userAgent;
			}
		}
		public UserAgentBehavior(string userAgent)
		{
			this._userAgent = userAgent;
		}
		public void Validate(ServiceEndpoint endpoint)
		{
		}
		public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
		{
		}
		public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
		{
		}
		public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
		{
			clientRuntime.ClientMessageInspectors.Add(new HttpHeaderInterceptor("User-Agent", () => this.UserAgent));
		}
	}
}
