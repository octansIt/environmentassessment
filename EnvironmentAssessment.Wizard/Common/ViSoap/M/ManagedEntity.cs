using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public ManagedEntity(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void Reload()
		{
			try
			{
				((VimService)this.Client.VimService).Reload((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference Rename_Task(string newName)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).Rename_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), newName));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void Rename(string newName)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).Rename_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), newName));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference Destroy_Task()
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).Destroy_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void Destroy()
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).Destroy_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
