namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterConfigSpecEx : ComputeResourceConfigSpec
	{
		protected ClusterDasConfigInfo _dasConfig;
		protected ClusterDasVmConfigSpec[] _dasVmConfigSpec;
		protected ClusterDrsConfigInfo _drsConfig;
		protected ClusterDrsVmConfigSpec[] _drsVmConfigSpec;
		protected ClusterRuleSpec[] _rulesSpec;
		protected ClusterOrchestrationInfo _orchestration;
		protected ClusterVmOrchestrationSpec[] _vmOrchestrationSpec;
		protected ClusterDpmConfigInfo _dpmConfig;
		protected ClusterDpmHostConfigSpec[] _dpmHostConfigSpec;
		protected VsanClusterConfigInfo _vsanConfig;
		protected VsanHostConfigInfo[] _vsanHostConfigSpec;
		protected ClusterGroupSpec[] _groupSpec;
		protected ClusterInfraUpdateHaConfigInfo _infraUpdateHaConfig;
		protected ClusterProactiveDrsConfigInfo _proactiveDrsConfig;
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
		public ClusterOrchestrationInfo Orchestration
		{
			get
			{
				return this._orchestration;
			}
			set
			{
				this._orchestration = value;
			}
		}
		public ClusterVmOrchestrationSpec[] VmOrchestrationSpec
		{
			get
			{
				return this._vmOrchestrationSpec;
			}
			set
			{
				this._vmOrchestrationSpec = value;
			}
		}
		public ClusterDpmConfigInfo DpmConfig
		{
			get
			{
				return this._dpmConfig;
			}
			set
			{
				this._dpmConfig = value;
			}
		}
		public ClusterDpmHostConfigSpec[] DpmHostConfigSpec
		{
			get
			{
				return this._dpmHostConfigSpec;
			}
			set
			{
				this._dpmHostConfigSpec = value;
			}
		}
		public VsanClusterConfigInfo VsanConfig
		{
			get
			{
				return this._vsanConfig;
			}
			set
			{
				this._vsanConfig = value;
			}
		}
		public VsanHostConfigInfo[] VsanHostConfigSpec
		{
			get
			{
				return this._vsanHostConfigSpec;
			}
			set
			{
				this._vsanHostConfigSpec = value;
			}
		}
		public ClusterGroupSpec[] GroupSpec
		{
			get
			{
				return this._groupSpec;
			}
			set
			{
				this._groupSpec = value;
			}
		}
		public ClusterInfraUpdateHaConfigInfo InfraUpdateHaConfig
		{
			get
			{
				return this._infraUpdateHaConfig;
			}
			set
			{
				this._infraUpdateHaConfig = value;
			}
		}
		public ClusterProactiveDrsConfigInfo ProactiveDrsConfig
		{
			get
			{
				return this._proactiveDrsConfig;
			}
			set
			{
				this._proactiveDrsConfig = value;
			}
		}
	}
}
