using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				ReconfigureSnmpAgentRequestType reconfigureSnmpAgentRequestType = new ReconfigureSnmpAgentRequestType();
				reconfigureSnmpAgentRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureSnmpAgentRequestType.spec = (VimApi_65.HostSnmpConfigSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.ReconfigureSnmpAgent(new ReconfigureSnmpAgentRequest(reconfigureSnmpAgentRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SendTestNotification()
		{
			try
			{
				SendTestNotificationRequestType sendTestNotificationRequestType = new SendTestNotificationRequestType();
				sendTestNotificationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.SendTestNotification(new SendTestNotificationRequest(sendTestNotificationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
