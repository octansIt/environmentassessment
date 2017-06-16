using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostEsxAgentHostManager : ViewBase
	{
		protected HostEsxAgentHostManagerConfigInfo _configInfo;
		public HostEsxAgentHostManagerConfigInfo ConfigInfo
		{
			get
			{
				return this._configInfo;
			}
		}
		public HostEsxAgentHostManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void EsxAgentHostManagerUpdateConfig(HostEsxAgentHostManagerConfigInfo configInfo)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).EsxAgentHostManagerUpdateConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostEsxAgentHostManagerConfigInfo)VIConvert.ToWsdlType(configInfo));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
