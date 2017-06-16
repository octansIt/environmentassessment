namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDrsConfigInfo : DynamicData
	{
		protected bool? _enabled;
		protected bool? _enableVmBehaviorOverrides;
		protected DrsBehavior? _defaultVmBehavior;
		protected int? _vmotionRate;
		protected OptionValue[] _option;
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public bool? EnableVmBehaviorOverrides
		{
			get
			{
				return this._enableVmBehaviorOverrides;
			}
			set
			{
				this._enableVmBehaviorOverrides = value;
			}
		}
		public DrsBehavior? DefaultVmBehavior
		{
			get
			{
				return this._defaultVmBehavior;
			}
			set
			{
				this._defaultVmBehavior = value;
			}
		}
		public int? VmotionRate
		{
			get
			{
				return this._vmotionRate;
			}
			set
			{
				this._vmotionRate = value;
			}
		}
		public OptionValue[] Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}
	}
}
