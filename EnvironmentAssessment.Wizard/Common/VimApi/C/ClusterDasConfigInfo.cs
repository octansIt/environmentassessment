namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasConfigInfo : DynamicData
	{
		protected bool? _enabled;
		protected string _vmMonitoring;
		protected string _hostMonitoring;
		protected string _vmComponentProtecting;
		protected int? _failoverLevel;
		protected ClusterDasAdmissionControlPolicy _admissionControlPolicy;
		protected bool? _admissionControlEnabled;
		protected ClusterDasVmSettings _defaultVmSettings;
		protected OptionValue[] _option;
		protected ManagedObjectReference[] _heartbeatDatastore;
		protected string _hBDatastoreCandidatePolicy;
		protected ClusterDasConfigInfo_LinkedView _linkedView;
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public string VmMonitoring
		{
			get
			{
				return this._vmMonitoring;
			}
			set
			{
				this._vmMonitoring = value;
			}
		}
		public string HostMonitoring
		{
			get
			{
				return this._hostMonitoring;
			}
			set
			{
				this._hostMonitoring = value;
			}
		}
		public string VmComponentProtecting
		{
			get
			{
				return this._vmComponentProtecting;
			}
			set
			{
				this._vmComponentProtecting = value;
			}
		}
		public int? FailoverLevel
		{
			get
			{
				return this._failoverLevel;
			}
			set
			{
				this._failoverLevel = value;
			}
		}
		public ClusterDasAdmissionControlPolicy AdmissionControlPolicy
		{
			get
			{
				return this._admissionControlPolicy;
			}
			set
			{
				this._admissionControlPolicy = value;
			}
		}
		public bool? AdmissionControlEnabled
		{
			get
			{
				return this._admissionControlEnabled;
			}
			set
			{
				this._admissionControlEnabled = value;
			}
		}
		public ClusterDasVmSettings DefaultVmSettings
		{
			get
			{
				return this._defaultVmSettings;
			}
			set
			{
				this._defaultVmSettings = value;
			}
		}
		public OptionValue[] Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}
		public ManagedObjectReference[] HeartbeatDatastore
		{
			get
			{
				return this._heartbeatDatastore;
			}
			set
			{
				this._heartbeatDatastore = value;
			}
		}
		public string HBDatastoreCandidatePolicy
		{
			get
			{
				return this._hBDatastoreCandidatePolicy;
			}
			set
			{
				this._hBDatastoreCandidatePolicy = value;
			}
		}
		public ClusterDasConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
