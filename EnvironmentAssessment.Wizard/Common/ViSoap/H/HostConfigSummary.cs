namespace EnvironmentAssessment.Common.VISoap
{
    public class HostConfigSummary : DynamicData
	{
		protected string _name;
		protected int _port;
		protected string _sslThumbprint;
		protected AboutInfo _product;
		protected bool _vmotionEnabled;
		protected bool _faultToleranceEnabled;
		protected HostFeatureVersionInfo[] _featureVersion;
		protected ManagedObjectReference _agentVmDatastore;
		protected ManagedObjectReference _agentVmNetwork;
		protected HostConfigSummary_LinkedView _linkedView;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public int Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
		public string SslThumbprint
		{
			get
			{
				return this._sslThumbprint;
			}
			set
			{
				this._sslThumbprint = value;
			}
		}
		public AboutInfo Product
		{
			get
			{
				return this._product;
			}
			set
			{
				this._product = value;
			}
		}
		public bool VmotionEnabled
		{
			get
			{
				return this._vmotionEnabled;
			}
			set
			{
				this._vmotionEnabled = value;
			}
		}
		public bool FaultToleranceEnabled
		{
			get
			{
				return this._faultToleranceEnabled;
			}
			set
			{
				this._faultToleranceEnabled = value;
			}
		}
		public HostFeatureVersionInfo[] FeatureVersion
		{
			get
			{
				return this._featureVersion;
			}
			set
			{
				this._featureVersion = value;
			}
		}
		public ManagedObjectReference AgentVmDatastore
		{
			get
			{
				return this._agentVmDatastore;
			}
			set
			{
				this._agentVmDatastore = value;
			}
		}
		public ManagedObjectReference AgentVmNetwork
		{
			get
			{
				return this._agentVmNetwork;
			}
			set
			{
				this._agentVmNetwork = value;
			}
		}
		public HostConfigSummary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
