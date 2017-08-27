namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterVmHostRuleInfo : ClusterRuleInfo
	{
		protected string _vmGroupName;
		protected string _affineHostGroupName;
		protected string _antiAffineHostGroupName;
		public string VmGroupName
		{
			get
			{
				return this._vmGroupName;
			}
			set
			{
				this._vmGroupName = value;
			}
		}
		public string AffineHostGroupName
		{
			get
			{
				return this._affineHostGroupName;
			}
			set
			{
				this._affineHostGroupName = value;
			}
		}
		public string AntiAffineHostGroupName
		{
			get
			{
				return this._antiAffineHostGroupName;
			}
			set
			{
				this._antiAffineHostGroupName = value;
			}
		}
	}
}
