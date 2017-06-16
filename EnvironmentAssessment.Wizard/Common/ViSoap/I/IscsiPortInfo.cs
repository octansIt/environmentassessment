namespace EnvironmentAssessment.Common.VISoap
{
    public class IscsiPortInfo : DynamicData
	{
		protected string _vnicDevice;
		protected HostVirtualNic _vnic;
		protected string _pnicDevice;
		protected PhysicalNic _pnic;
		protected string _switchName;
		protected string _switchUuid;
		protected string _portgroupName;
		protected string _portgroupKey;
		protected string _portKey;
		protected IscsiStatus _complianceStatus;
		protected string _pathStatus;
		public string VnicDevice
		{
			get
			{
				return this._vnicDevice;
			}
			set
			{
				this._vnicDevice = value;
			}
		}
		public HostVirtualNic Vnic
		{
			get
			{
				return this._vnic;
			}
			set
			{
				this._vnic = value;
			}
		}
		public string PnicDevice
		{
			get
			{
				return this._pnicDevice;
			}
			set
			{
				this._pnicDevice = value;
			}
		}
		public PhysicalNic Pnic
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
		public string SwitchName
		{
			get
			{
				return this._switchName;
			}
			set
			{
				this._switchName = value;
			}
		}
		public string SwitchUuid
		{
			get
			{
				return this._switchUuid;
			}
			set
			{
				this._switchUuid = value;
			}
		}
		public string PortgroupName
		{
			get
			{
				return this._portgroupName;
			}
			set
			{
				this._portgroupName = value;
			}
		}
		public string PortgroupKey
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
		public string PortKey
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
		public IscsiStatus ComplianceStatus
		{
			get
			{
				return this._complianceStatus;
			}
			set
			{
				this._complianceStatus = value;
			}
		}
		public string PathStatus
		{
			get
			{
				return this._pathStatus;
			}
			set
			{
				this._pathStatus = value;
			}
		}
	}
}
