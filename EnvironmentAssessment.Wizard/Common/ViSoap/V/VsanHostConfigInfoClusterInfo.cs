namespace EnvironmentAssessment.Common.VISoap
{
    public class VsanHostConfigInfoClusterInfo : DynamicData
	{
		protected string _uuid;
		protected string _nodeUuid;
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
	}
}
