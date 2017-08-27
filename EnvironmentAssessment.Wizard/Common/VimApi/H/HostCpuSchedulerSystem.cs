using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				EnableHyperThreadingRequestType enableHyperThreadingRequestType = new EnableHyperThreadingRequestType();
				enableHyperThreadingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.EnableHyperThreading(new EnableHyperThreadingRequest(enableHyperThreadingRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DisableHyperThreading()
		{
			try
			{
				DisableHyperThreadingRequestType disableHyperThreadingRequestType = new DisableHyperThreadingRequestType();
				disableHyperThreadingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DisableHyperThreading(new DisableHyperThreadingRequest(disableHyperThreadingRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
