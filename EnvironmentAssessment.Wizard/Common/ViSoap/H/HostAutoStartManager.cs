using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				((VimService)this.Client.VimService).ReconfigureAutostart((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostAutoStartManagerConfig)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void AutoStartPowerOn()
		{
			try
			{
				((VimService)this.Client.VimService).AutoStartPowerOn((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void AutoStartPowerOff()
		{
			try
			{
				((VimService)this.Client.VimService).AutoStartPowerOff((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
