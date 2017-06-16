namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterConfigSpec : DynamicData
	{
		protected ClusterDasConfigInfo _dasConfig;
		protected ClusterDasVmConfigSpec[] _dasVmConfigSpec;
		protected ClusterDrsConfigInfo _drsConfig;
		protected ClusterDrsVmConfigSpec[] _drsVmConfigSpec;
		protected ClusterRuleSpec[] _rulesSpec;
		public ClusterDasConfigInfo DasConfig
		{
			get
			{
				return this._dasConfig;
			}
			set
			{
				this._dasConfig = value;
			}
		}
		public ClusterDasVmConfigSpec[] DasVmConfigSpec
		{
			get
			{
				return this._dasVmConfigSpec;
			}
			set
			{
				this._dasVmConfigSpec = value;
			}
		}
		public ClusterDrsConfigInfo DrsConfig
		{
			get
			{
				return this._drsConfig;
			}
			set
			{
				this._drsConfig = value;
			}
		}
		public ClusterDrsVmConfigSpec[] DrsVmConfigSpec
		{
			get
			{
				return this._drsVmConfigSpec;
			}
			set
			{
				this._drsVmConfigSpec = value;
			}
		}
		public ClusterRuleSpec[] RulesSpec
		{
			get
			{
				return this._rulesSpec;
			}
			set
			{
				this._rulesSpec = value;
			}
		}
	}
}
