namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterConfigInfoEx : ComputeResourceConfigInfo
	{
		protected ClusterDasConfigInfo _dasConfig;
		protected ClusterDasVmConfigInfo[] _dasVmConfig;
		protected ClusterDrsConfigInfo _drsConfig;
		protected ClusterDrsVmConfigInfo[] _drsVmConfig;
		protected ClusterRuleInfo[] _rule;
		protected ClusterDpmConfigInfo _dpmConfigInfo;
		protected ClusterDpmHostConfigInfo[] _dpmHostConfig;
		protected VsanClusterConfigInfo _vsanConfigInfo;
		protected VsanHostConfigInfo[] _vsanHostConfig;
		protected ClusterGroupInfo[] _group;
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
		public ClusterDpmConfigInfo DpmConfigInfo
		{
			get
			{
				return this._dpmConfigInfo;
			}
			set
			{
				this._dpmConfigInfo = value;
			}
		}
		public ClusterDpmHostConfigInfo[] DpmHostConfig
		{
			get
			{
				return this._dpmHostConfig;
			}
			set
			{
				this._dpmHostConfig = value;
			}
		}
		public VsanClusterConfigInfo VsanConfigInfo
		{
			get
			{
				return this._vsanConfigInfo;
			}
			set
			{
				this._vsanConfigInfo = value;
			}
		}
		public VsanHostConfigInfo[] VsanHostConfig
		{
			get
			{
				return this._vsanHostConfig;
			}
			set
			{
				this._vsanHostConfig = value;
			}
		}
		public ClusterGroupInfo[] Group
		{
			get
			{
				return this._group;
			}
			set
			{
				this._group = value;
			}
		}
	}
}
