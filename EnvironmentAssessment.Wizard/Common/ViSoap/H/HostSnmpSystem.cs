using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSnmpSystem : ViewBase
	{
		protected HostSnmpConfigSpec _configuration;
		protected HostSnmpSystemAgentLimits _limits;
		public HostSnmpConfigSpec Configuration
		{
			get
			{
				return this._configuration;
			}
		}
		public HostSnmpSystemAgentLimits Limits
		{
			get
			{
				return this._limits;
			}
		}
		public HostSnmpSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void ReconfigureSnmpAgent(HostSnmpConfigSpec spec)
		{
			try
			{
				((VimService)this.Client.VimService).ReconfigureSnmpAgent((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostSnmpConfigSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void SendTestNotification()
		{
			try
			{
				((VimService)this.Client.VimService).SendTestNotification((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
