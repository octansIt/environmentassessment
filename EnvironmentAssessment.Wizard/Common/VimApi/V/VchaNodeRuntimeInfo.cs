namespace EnvironmentAssessment.Common.VimApi
{
	public class VchaNodeRuntimeInfo : DynamicData
	{
		protected string _nodeState;
		protected string _nodeRole;
		protected string _nodeIp;
		public string NodeState
		{
			get
			{
				return this._nodeState;
			}
			set
			{
				this._nodeState = value;
			}
		}
		public string NodeRole
		{
			get
			{
				return this._nodeRole;
			}
			set
			{
				this._nodeRole = value;
			}
		}
		public string NodeIp
		{
			get
			{
				return this._nodeIp;
			}
			set
			{
				this._nodeIp = value;
			}
		}
	}
}
