namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostMembershipInfo : DynamicData
	{
		protected string _nodeUuid;
		protected string _hostname;
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
		public string Hostname
		{
			get
			{
				return this._hostname;
			}
			set
			{
				this._hostname = value;
			}
		}
	}
}
