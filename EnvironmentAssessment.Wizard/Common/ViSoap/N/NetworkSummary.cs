namespace EnvironmentAssessment.Common.VISoap
{
    public class NetworkSummary : DynamicData
	{
		protected ManagedObjectReference _network;
		protected string _name;
		protected bool _accessible;
		protected string _ipPoolName;
		protected int? _ipPoolId;
		protected NetworkSummary_LinkedView _linkedView;
		public ManagedObjectReference Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
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
		public bool Accessible
		{
			get
			{
				return this._accessible;
			}
			set
			{
				this._accessible = value;
			}
		}
		public string IpPoolName
		{
			get
			{
				return this._ipPoolName;
			}
			set
			{
				this._ipPoolName = value;
			}
		}
		public int? IpPoolId
		{
			get
			{
				return this._ipPoolId;
			}
			set
			{
				this._ipPoolId = value;
			}
		}
		public NetworkSummary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
