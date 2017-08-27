using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class Task : ExtensibleManagedObject
	{
		protected TaskInfo _info;
		public TaskInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public Task(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void CancelTask()
		{
			try
			{
				CancelTaskRequestType cancelTaskRequestType = new CancelTaskRequestType();
				cancelTaskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.CancelTask(new CancelTaskRequest(cancelTaskRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateProgress(int percentDone)
		{
			try
			{
				UpdateProgressRequestType updateProgressRequestType = new UpdateProgressRequestType();
				updateProgressRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateProgressRequestType.percentDone = percentDone;
				this.VimServiceProxy.UpdateProgress(new UpdateProgressRequest(updateProgressRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SetTaskState(TaskInfoState state, object result, LocalizedMethodFault fault)
		{
			try
			{
				SetTaskStateRequestType setTaskStateRequestType = new SetTaskStateRequestType();
				setTaskStateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setTaskStateRequestType.state = (VimApi_65.TaskInfoState)VIConvert.ToWsdlType(state);
				setTaskStateRequestType.result = result;
				setTaskStateRequestType.fault = (VimApi_65.LocalizedMethodFault)VIConvert.ToWsdlType(fault);
				this.VimServiceProxy.SetTaskState(new SetTaskStateRequest(setTaskStateRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SetTaskDescription(LocalizableMessage description)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				SetTaskDescriptionRequestType setTaskDescriptionRequestType = new SetTaskDescriptionRequestType();
				setTaskDescriptionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setTaskDescriptionRequestType.description = (VimApi_65.LocalizableMessage)VIConvert.ToWsdlType(description);
				this.VimServiceProxy.SetTaskDescription(new SetTaskDescriptionRequest(setTaskDescriptionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
