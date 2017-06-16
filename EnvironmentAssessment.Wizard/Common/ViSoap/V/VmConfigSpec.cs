namespace EnvironmentAssessment.Common.VISoap
{
    public class VmConfigSpec : DynamicData
	{
		protected VAppProductSpec[] _product;
		protected VAppPropertySpec[] _property;
		protected VAppIPAssignmentInfo _ipAssignment;
		protected string[] _eula;
		protected VAppOvfSectionSpec[] _ovfSection;
		protected string[] _ovfEnvironmentTransport;
		protected bool? _installBootRequired;
		protected int? _installBootStopDelay;
		public VAppProductSpec[] Product
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
		public VAppPropertySpec[] Property
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
		public VAppOvfSectionSpec[] OvfSection
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
		public bool? InstallBootRequired
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
		public int? InstallBootStopDelay
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
