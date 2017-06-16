using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HostHealthStatusSystem : ViewBase
	{
		protected HealthSystemRuntime _runtime;
		public HealthSystemRuntime Runtime
		{
			get
			{
				return this._runtime;
			}
		}
		public HostHealthStatusSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RefreshHealthStatusSystem()
		{
			try
			{
				((VimService)this.Client.VimService).RefreshHealthStatusSystem((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ResetSystemHealthInfo()
		{
			try
			{
				((VimService)this.Client.VimService).ResetSystemHealthInfo((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
