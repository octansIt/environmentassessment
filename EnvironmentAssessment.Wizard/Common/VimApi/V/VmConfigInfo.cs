namespace EnvironmentAssessment.Common.VimApi
{
	public class VmConfigInfo : DynamicData
	{
		protected VAppProductInfo[] _product;
		protected VAppPropertyInfo[] _property;
		protected VAppIPAssignmentInfo _ipAssignment;
		protected string[] _eula;
		protected VAppOvfSectionInfo[] _ovfSection;
		protected string[] _ovfEnvironmentTransport;
		protected bool _installBootRequired;
		protected int _installBootStopDelay;
		public VAppProductInfo[] Product
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
		public VAppPropertyInfo[] Property
		{
			get
			{
				return this._property;
			}
			set
			{
				this._property = value;
			}
		}
		public VAppIPAssignmentInfo IpAssignment
		{
			get
			{
				return this._ipAssignment;
			}
			set
			{
				this._ipAssignment = value;
			}
		}
		public string[] Eula
		{
			get
			{
				return this._eula;
			}
			set
			{
				this._eula = value;
			}
		}
		public VAppOvfSectionInfo[] OvfSection
		{
			get
			{
				return this._ovfSection;
			}
			set
			{
				this._ovfSection = value;
			}
		}
		public string[] OvfEnvironmentTransport
		{
			get
			{
				return this._ovfEnvironmentTransport;
			}
			set
			{
				this._ovfEnvironmentTransport = value;
			}
		}
		public bool InstallBootRequired
		{
			get
			{
				return this._installBootRequired;
			}
			set
			{
				this._installBootRequired = value;
			}
		}
		public int InstallBootStopDelay
		{
			get
			{
				return this._installBootStopDelay;
			}
			set
			{
				this._installBootStopDelay = value;
			}
		}
	}
}
