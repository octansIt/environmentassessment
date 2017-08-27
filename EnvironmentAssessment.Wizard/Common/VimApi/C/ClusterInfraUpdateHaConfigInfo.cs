namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterInfraUpdateHaConfigInfo : DynamicData
	{
		protected bool? _enabled;
		protected string _behavior;
		protected string _moderateRemediation;
		protected string _severeRemediation;
		protected string[] _providers;
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
		public string Behavior
		{
			get
			{
				return this._behavior;
			}
			set
			{
				this._behavior = value;
			}
		}
		public string ModerateRemediation
		{
			get
			{
				return this._moderateRemediation;
			}
			set
			{
				this._moderateRemediation = value;
			}
		}
		public string SevereRemediation
		{
			get
			{
				return this._severeRemediation;
			}
			set
			{
				this._severeRemediation = value;
			}
		}
		public string[] Providers
		{
			get
			{
				return this._providers;
			}
			set
			{
				this._providers = value;
			}
		}
	}
}
