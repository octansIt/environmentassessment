namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDpmConfigInfo : DynamicData
	{
		protected bool? _enabled;
		protected DpmBehavior? _defaultDpmBehavior;
		protected int? _hostPowerActionRate;
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
		public DpmBehavior? DefaultDpmBehavior
		{
			get
			{
				return this._defaultDpmBehavior;
			}
			set
			{
				this._defaultDpmBehavior = value;
			}
		}
		public int? HostPowerActionRate
		{
			get
			{
				return this._hostPowerActionRate;
			}
			set
			{
				this._hostPowerActionRate = value;
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
