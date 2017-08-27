using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class ScheduledTask : ExtensibleManagedObject
	{
		protected ScheduledTaskInfo _info;
		public ScheduledTaskInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public ScheduledTask(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RemoveScheduledTask()
		{
			try
			{
				RemoveScheduledTaskRequestType removeScheduledTaskRequestType = new RemoveScheduledTaskRequestType();
				removeScheduledTaskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RemoveScheduledTask(new RemoveScheduledTaskRequest(removeScheduledTaskRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ReconfigureScheduledTask(ScheduledTaskSpec spec)
		{
			try
			{
				ReconfigureScheduledTaskRequestType reconfigureScheduledTaskRequestType = new ReconfigureScheduledTaskRequestType();
				reconfigureScheduledTaskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureScheduledTaskRequestType.spec = (VimApi_65.ScheduledTaskSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.ReconfigureScheduledTask(new ReconfigureScheduledTaskRequest(reconfigureScheduledTaskRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RunScheduledTask()
		{
			try
			{
				RunScheduledTaskRequestType runScheduledTaskRequestType = new RunScheduledTaskRequestType();
				runScheduledTaskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RunScheduledTask(new RunScheduledTaskRequest(runScheduledTaskRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
