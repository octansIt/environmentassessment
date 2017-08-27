using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class ManagedEntity : EntityViewBase
	{
		protected ManagedObjectReference _parent;
		protected CustomFieldValue[] _customValue;
		protected ManagedEntityStatus _overallStatus;
		protected ManagedEntityStatus _configStatus;
		protected Event[] _configIssue;
		protected int[] _effectiveRole;
		protected Permission[] _permission;
		protected string _name;
		protected string[] _disabledMethod;
		protected ManagedObjectReference[] _recentTask;
		protected AlarmState[] _declaredAlarmState;
		protected AlarmState[] _triggeredAlarmState;
		protected bool _alarmActionsEnabled;
		protected Tag[] _tag;
		protected ManagedEntity_LinkedView _linkedView;
		public ManagedObjectReference Parent
		{
			get
			{
				return this._parent;
			}
		}
		public CustomFieldValue[] CustomValue
		{
			get
			{
				return this._customValue;
			}
		}
		public ManagedEntityStatus OverallStatus
		{
			get
			{
				return this._overallStatus;
			}
		}
		public ManagedEntityStatus ConfigStatus
		{
			get
			{
				return this._configStatus;
			}
		}
		public Event[] ConfigIssue
		{
			get
			{
				return this._configIssue;
			}
		}
		public int[] EffectiveRole
		{
			get
			{
				return this._effectiveRole;
			}
		}
		public Permission[] Permission
		{
			get
			{
				return this._permission;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
		}
		public string[] DisabledMethod
		{
			get
			{
				return this._disabledMethod;
			}
		}
		public ManagedObjectReference[] RecentTask
		{
			get
			{
				return this._recentTask;
			}
		}
		public AlarmState[] DeclaredAlarmState
		{
			get
			{
				return this._declaredAlarmState;
			}
		}
		public AlarmState[] TriggeredAlarmState
		{
			get
			{
				return this._triggeredAlarmState;
			}
		}
		public bool AlarmActionsEnabled
		{
			get
			{
				return this._alarmActionsEnabled;
			}
		}
		public Tag[] Tag
		{
			get
			{
				return this._tag;
			}
		}
		public ManagedEntity_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public ManagedEntity(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void Reload()
		{
			try
			{
				ReloadRequestType reloadRequestType = new ReloadRequestType();
				reloadRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.Reload(new ReloadRequest(reloadRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference Rename_Task(string newName)
		{
			ManagedObjectReference result;
			try
			{
				RenameRequestType renameRequestType = new RenameRequestType();
				renameRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				renameRequestType.newName = newName;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.Rename_Task(new Rename_TaskRequest(renameRequestType)).Rename_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void Rename(string newName)
		{
			try
			{
				ManagedObjectReference taskReference = this.Rename_Task(newName);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference Destroy_Task()
		{
			ManagedObjectReference result;
			try
			{
				DestroyRequestType destroyRequestType = new DestroyRequestType();
				destroyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.Destroy_Task(new Destroy_TaskRequest(destroyRequestType)).Destroy_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void Destroy()
		{
			try
			{
				ManagedObjectReference taskReference = this.Destroy_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
