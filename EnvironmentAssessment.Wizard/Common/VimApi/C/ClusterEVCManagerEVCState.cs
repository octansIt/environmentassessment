namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterEVCManagerEVCState : DynamicData
	{
		protected EVCMode[] _supportedEVCMode;
		protected string _currentEVCModeKey;
		protected HostCpuIdInfo[] _guaranteedCPUFeatures;
		protected HostFeatureCapability[] _featureCapability;
		protected HostFeatureMask[] _featureMask;
		protected VirtualMachineFeatureRequirement[] _featureRequirement;
		public EVCMode[] SupportedEVCMode
		{
			get
			{
				return this._supportedEVCMode;
			}
			set
			{
				this._supportedEVCMode = value;
			}
		}
		public string CurrentEVCModeKey
		{
			get
			{
				return this._currentEVCModeKey;
			}
			set
			{
				this._currentEVCModeKey = value;
			}
		}
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
	}
}
