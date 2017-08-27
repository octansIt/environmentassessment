namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterConfigInfo : DynamicData
	{
		protected ClusterDasConfigInfo _dasConfig;
		protected ClusterDasVmConfigInfo[] _dasVmConfig;
		protected ClusterDrsConfigInfo _drsConfig;
		protected ClusterDrsVmConfigInfo[] _drsVmConfig;
		protected ClusterRuleInfo[] _rule;
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
		public ClusterDasVmConfigInfo[] DasVmConfig
		{
			get
			{
				return this._dasVmConfig;
			}
			set
			{
				this._dasVmConfig = value;
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
		public ClusterDrsVmConfigInfo[] DrsVmConfig
		{
			get
			{
				return this._drsVmConfig;
			}
			set
			{
				this._drsVmConfig = value;
			}
		}
		public ClusterRuleInfo[] Rule
		{
			get
			{
				return this._rule;
			}
			set
			{
				this._rule = value;
			}
		}
	}
}
