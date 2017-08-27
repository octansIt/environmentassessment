namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostClusterStatus : DynamicData
	{
		protected string _uuid;
		protected string _nodeUuid;
		protected string _health;
		protected VsanHostClusterStatusState _nodeState;
		protected string[] _memberUuid;
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public string NodeUuid
		{
			get
			{
				return this._nodeUuid;
			}
			set
			{
				this._nodeUuid = value;
			}
		}
		public string Health
		{
			get
			{
				return this._health;
			}
			set
			{
				this._health = value;
			}
		}
		public VsanHostClusterStatusState NodeState
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
		public string[] MemberUuid
		{
			get
			{
				return this._memberUuid;
			}
			set
			{
				this._memberUuid = value;
			}
		}
	}
}
