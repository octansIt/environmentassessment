using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HostCpuSchedulerSystem : ExtensibleManagedObject
	{
		protected HostHyperThreadScheduleInfo _hyperthreadInfo;
		public HostHyperThreadScheduleInfo HyperthreadInfo
		{
			get
			{
				return this._hyperthreadInfo;
			}
		}
		public HostCpuSchedulerSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void EnableHyperThreading()
		{
			try
			{
				((VimService)this.Client.VimService).EnableHyperThreading((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DisableHyperThreading()
		{
			try
			{
				((VimService)this.Client.VimService).DisableHyperThreading((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
