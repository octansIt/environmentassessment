using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostAutoStartManager : ViewBase
	{
		protected HostAutoStartManagerConfig _config;
		public HostAutoStartManagerConfig Config
		{
			get
			{
				return this._config;
			}
		}
		public HostAutoStartManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void ReconfigureAutostart(HostAutoStartManagerConfig spec)
		{
			try
			{
				ReconfigureAutostartRequestType reconfigureAutostartRequestType = new ReconfigureAutostartRequestType();
				reconfigureAutostartRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureAutostartRequestType.spec = (VimApi_65.HostAutoStartManagerConfig)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.ReconfigureAutostart(new ReconfigureAutostartRequest(reconfigureAutostartRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AutoStartPowerOn()
		{
			try
			{
				AutoStartPowerOnRequestType autoStartPowerOnRequestType = new AutoStartPowerOnRequestType();
				autoStartPowerOnRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.AutoStartPowerOn(new AutoStartPowerOnRequest(autoStartPowerOnRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AutoStartPowerOff()
		{
			try
			{
				AutoStartPowerOffRequestType autoStartPowerOffRequestType = new AutoStartPowerOffRequestType();
				autoStartPowerOffRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.AutoStartPowerOff(new AutoStartPowerOffRequest(autoStartPowerOffRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
