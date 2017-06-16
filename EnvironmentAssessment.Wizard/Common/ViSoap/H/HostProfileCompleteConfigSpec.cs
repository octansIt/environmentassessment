namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProfileCompleteConfigSpec : HostProfileConfigSpec
	{
		protected HostApplyProfile _applyProfile;
		protected ComplianceProfile _customComplyProfile;
		protected bool _disabledExpressionListChanged;
		protected string[] _disabledExpressionList;
		protected ManagedObjectReference _validatorHost;
		protected bool? _validating;
		protected HostProfileCompleteConfigSpec_LinkedView _linkedView;
		public HostApplyProfile ApplyProfile
		{
			get
			{
				return this._applyProfile;
			}
			set
			{
				this._applyProfile = value;
			}
		}
		public ComplianceProfile CustomComplyProfile
		{
			get
			{
				return this._customComplyProfile;
			}
			set
			{
				this._customComplyProfile = value;
			}
		}
		public bool DisabledExpressionListChanged
		{
			get
			{
				return this._disabledExpressionListChanged;
			}
			set
			{
				this._disabledExpressionListChanged = value;
			}
		}
		public string[] DisabledExpressionList
		{
			get
			{
				return this._disabledExpressionList;
			}
			set
			{
				this._disabledExpressionList = value;
			}
		}
		public ManagedObjectReference ValidatorHost
		{
			get
			{
				return this._validatorHost;
			}
			set
			{
				this._validatorHost = value;
			}
		}
		public bool? Validating
		{
			get
			{
				return this._validating;
			}
			set
			{
				this._validating = value;
			}
		}
		public HostProfileCompleteConfigSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
