namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitchPortCriteria : DynamicData
	{
		protected bool? _connected;
		protected bool? _active;
		protected bool? _uplinkPort;
		protected ManagedObjectReference _scope;
		protected string[] _portgroupKey;
		protected bool? _inside;
		protected string[] _portKey;
		protected DistributedVirtualSwitchPortCriteria_LinkedView _linkedView;
		public bool? Connected
		{
			get
			{
				return this._connected;
			}
			set
			{
				this._connected = value;
			}
		}
		public bool? Active
		{
			get
			{
				return this._active;
			}
			set
			{
				this._active = value;
			}
		}
		public bool? UplinkPort
		{
			get
			{
				return this._uplinkPort;
			}
			set
			{
				this._uplinkPort = value;
			}
		}
		public ManagedObjectReference Scope
		{
			get
			{
				return this._scope;
			}
			set
			{
				this._scope = value;
			}
		}
		public string[] PortgroupKey
		{
			get
			{
				return this._portgroupKey;
			}
			set
			{
				this._portgroupKey = value;
			}
		}
		public bool? Inside
		{
			get
			{
				return this._inside;
			}
			set
			{
				this._inside = value;
			}
		}
		public string[] PortKey
		{
			get
			{
				return this._portKey;
			}
			set
			{
				this._portKey = value;
			}
		}
		public DistributedVirtualSwitchPortCriteria_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
