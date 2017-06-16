namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSnmpConfigSpec : DynamicData
	{
		protected bool? _enabled;
		protected int? _port;
		protected string[] _readOnlyCommunities;
		protected HostSnmpDestination[] _trapTargets;
		protected KeyValue[] _option;
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
		public int? Port
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
		public string[] ReadOnlyCommunities
		{
			get
			{
				return this._readOnlyCommunities;
			}
			set
			{
				this._readOnlyCommunities = value;
			}
		}
		public HostSnmpDestination[] TrapTargets
		{
			get
			{
				return this._trapTargets;
			}
			set
			{
				this._trapTargets = value;
			}
		}
		public KeyValue[] Option
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
	}
}
