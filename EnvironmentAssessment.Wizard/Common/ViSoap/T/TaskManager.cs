using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateCollectorForTasks((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.TaskFilterSpec)VIConvert.ToWsdlType(filter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
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
                result = (TaskInfo)VIConvert.ToVim(((VimService)this.Client.VimService).CreateTask((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(obj), taskTypeId, initiatedBy, cancelable, parentTaskKey, activationId));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}
