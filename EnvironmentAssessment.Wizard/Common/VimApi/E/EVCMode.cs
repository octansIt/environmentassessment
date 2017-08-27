namespace EnvironmentAssessment.Common.VimApi
{
	public class EVCMode : ElementDescription
	{
		protected HostCpuIdInfo[] _guaranteedCPUFeatures;
		protected HostFeatureCapability[] _featureCapability;
		protected HostFeatureMask[] _featureMask;
		protected VirtualMachineFeatureRequirement[] _featureRequirement;
		protected string _vendor;
		protected string[] _track;
		protected int _vendorTier;
		public HostCpuIdInfo[] GuaranteedCPUFeatures
		{
			get
			{
				return this._guaranteedCPUFeatures;
			}
			set
			{
				this._guaranteedCPUFeatures = value;
			}
		}
		public HostFeatureCapability[] FeatureCapability
		{
			get
			{
				return this._featureCapability;
			}
			set
			{
				this._featureCapability = value;
			}
		}
		public HostFeatureMask[] FeatureMask
		{
			get
			{
				return this._featureMask;
			}
			set
			{
				this._featureMask = value;
			}
		}
		public VirtualMachineFeatureRequirement[] FeatureRequirement
		{
			get
			{
				return this._featureRequirement;
			}
			set
			{
				this._featureRequirement = value;
			}
		}
		public string Vendor
		{
			get
			{
				return this._vendor;
			}
			set
			{
				this._vendor = value;
			}
		}
		public string[] Track
		{
			get
			{
				return this._track;
			}
			set
			{
				this._track = value;
			}
		}
		public int VendorTier
		{
			get
			{
				return this._vendorTier;
			}
			set
			{
				this._vendorTier = value;
			}
		}
	}
}
