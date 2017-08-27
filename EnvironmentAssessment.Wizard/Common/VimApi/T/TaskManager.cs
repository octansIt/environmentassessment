using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskManager : ViewBase
	{
		protected ManagedObjectReference[] _recentTask;
		protected TaskDescription _description;
		protected int _maxCollector;
		protected TaskManager_LinkedView _linkedView;
		public ManagedObjectReference[] RecentTask
		{
			get
			{
				return this._recentTask;
			}
		}
		public TaskDescription Description
		{
			get
			{
				return this._description;
			}
		}
		public int MaxCollector
		{
			get
			{
				return this._maxCollector;
			}
		}
		public TaskManager_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public TaskManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateCollectorForTasks(TaskFilterSpec filter)
		{
			ManagedObjectReference result;
			try
			{
				CreateCollectorForTasksRequestType createCollectorForTasksRequestType = new CreateCollectorForTasksRequestType();
				createCollectorForTasksRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createCollectorForTasksRequestType.filter = (VimApi_65.TaskFilterSpec)VIConvert.ToWsdlType(filter);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateCollectorForTasks(new CreateCollectorForTasksRequest(createCollectorForTasksRequestType)).CreateCollectorForTasksResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		[Obsolete("The method CreateTask in TaskManager is deprecated in version 5.5.")]
		public TaskInfo CreateTask(ManagedObjectReference obj, string taskTypeId, string initiatedBy, bool cancelable, string parentTaskKey)
		{
			return this.CreateTask(obj, taskTypeId, initiatedBy, cancelable, parentTaskKey, null);
		}
		public TaskInfo CreateTask(ManagedObjectReference obj, string taskTypeId, string initiatedBy, bool cancelable, string parentTaskKey, string activationId)
		{
			TaskInfo result;
			try
			{
				CreateTaskRequestType createTaskRequestType = new CreateTaskRequestType();
				createTaskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createTaskRequestType.obj = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(obj);
				createTaskRequestType.taskTypeId = taskTypeId;
				createTaskRequestType.initiatedBy = initiatedBy;
				createTaskRequestType.cancelable = cancelable;
				createTaskRequestType.parentTaskKey = parentTaskKey;
				createTaskRequestType.activationId = activationId;
				result = (TaskInfo)VIConvert.ToVim(this.VimServiceProxy.CreateTask(new CreateTaskRequest(createTaskRequestType)).CreateTaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
