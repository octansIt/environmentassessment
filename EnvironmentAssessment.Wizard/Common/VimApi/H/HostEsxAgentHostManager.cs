using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
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
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				EsxAgentHostManagerUpdateConfigRequestType esxAgentHostManagerUpdateConfigRequestType = new EsxAgentHostManagerUpdateConfigRequestType();
				esxAgentHostManagerUpdateConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				esxAgentHostManagerUpdateConfigRequestType.configInfo = (VimApi_65.HostEsxAgentHostManagerConfigInfo)VIConvert.ToWsdlType(configInfo);
				this.VimServiceProxy.EsxAgentHostManagerUpdateConfig(new EsxAgentHostManagerUpdateConfigRequest(esxAgentHostManagerUpdateConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
