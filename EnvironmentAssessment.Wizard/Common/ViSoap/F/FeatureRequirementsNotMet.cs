namespace EnvironmentAssessment.Common.VISoap
{
    public class FeatureRequirementsNotMet : VirtualHardwareCompatibilityIssue
	{
		protected VirtualMachineFeatureRequirement[] _featureRequirement;
		protected ManagedObjectReference _vm;
		protected ManagedObjectReference _host;
		protected FeatureRequirementsNotMet_LinkedView _linkedView;
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
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public FeatureRequirementsNotMet_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
