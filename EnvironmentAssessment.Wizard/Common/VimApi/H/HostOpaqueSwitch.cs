namespace EnvironmentAssessment.Common.VimApi
{
	public class HostOpaqueSwitch : DynamicData
	{
		protected string _key;
		protected string _name;
		protected string[] _pnic;
		protected HostOpaqueSwitchPhysicalNicZone[] _pnicZone;
		protected string _status;
		protected HostVirtualNic[] _vtep;
		protected OptionValue[] _extraConfig;
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
		public HostOpaqueSwitchPhysicalNicZone[] PnicZone
		{
			get
			{
				return this._pnicZone;
			}
			set
			{
				this._pnicZone = value;
			}
		}
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public HostVirtualNic[] Vtep
		{
			get
			{
				return this._vtep;
			}
			set
			{
				this._vtep = value;
			}
		}
		public OptionValue[] ExtraConfig
		{
			get
			{
				return this._extraConfig;
			}
			set
			{
				this._extraConfig = value;
			}
		}
	}
}
