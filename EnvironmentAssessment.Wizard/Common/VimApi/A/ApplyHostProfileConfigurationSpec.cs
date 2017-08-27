namespace EnvironmentAssessment.Common.VimApi
{
	public class ApplyHostProfileConfigurationSpec : ProfileExecuteResult
	{
		protected ManagedObjectReference _host;
		protected string[] _taskListRequirement;
		protected LocalizableMessage[] _taskDescription;
		protected bool? _rebootStateless;
		protected bool? _rebootHost;
		protected LocalizedMethodFault _faultData;
		protected ApplyHostProfileConfigurationSpec_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public string[] TaskListRequirement
		{
			get
			{
				return this._taskListRequirement;
			}
			set
			{
				this._taskListRequirement = value;
			}
		}
		public LocalizableMessage[] TaskDescription
		{
			get
			{
				return this._taskDescription;
			}
			set
			{
				this._taskDescription = value;
			}
		}
		public bool? RebootStateless
		{
			get
			{
				return this._rebootStateless;
			}
			set
			{
				this._rebootStateless = value;
			}
		}
		public bool? RebootHost
		{
			get
			{
				return this._rebootHost;
			}
			set
			{
				this._rebootHost = value;
			}
		}
		public LocalizedMethodFault FaultData
		{
			get
			{
				return this._faultData;
			}
			set
			{
				this._faultData = value;
			}
		}
		public ApplyHostProfileConfigurationSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
