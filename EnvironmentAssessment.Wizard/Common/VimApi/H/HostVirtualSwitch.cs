namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualSwitch : DynamicData
	{
		protected string _name;
		protected string _key;
		protected int _numPorts;
		protected int _numPortsAvailable;
		protected int? _mtu;
		protected string[] _portgroup;
		protected string[] _pnic;
		protected HostVirtualSwitchSpec _spec;
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
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public int NumPorts
		{
			get
			{
				return this._numPorts;
			}
			set
			{
				this._numPorts = value;
			}
		}
		public int NumPortsAvailable
		{
			get
			{
				return this._numPortsAvailable;
			}
			set
			{
				this._numPortsAvailable = value;
			}
		}
		public int? Mtu
		{
			get
			{
				return this._mtu;
			}
			set
			{
				this._mtu = value;
			}
		}
		public string[] Portgroup
		{
			get
			{
				return this._portgroup;
			}
			set
			{
				this._portgroup = value;
			}
		}
		public string[] Pnic
		{
			get
			{
				return this._pnic;
			}
			set
			{
				this._pnic = value;
			}
		}
		public HostVirtualSwitchSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
	}
}
