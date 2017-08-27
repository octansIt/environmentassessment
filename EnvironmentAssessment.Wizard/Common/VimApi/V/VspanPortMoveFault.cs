namespace EnvironmentAssessment.Common.VimApi
{
	public class VspanPortMoveFault : DvsFault
	{
		protected string _srcPortgroupName;
		protected string _destPortgroupName;
		protected string _portKey;
		public string SrcPortgroupName
		{
			get
			{
				return this._srcPortgroupName;
			}
			set
			{
				this._srcPortgroupName = value;
			}
		}
		public string DestPortgroupName
		{
			get
			{
				return this._destPortgroupName;
			}
			set
			{
				this._destPortgroupName = value;
			}
		}
		public string PortKey
		{
			get
			{
				return this._portKey;
			}
			set
			{
				this._portKey = value;
			}
		}
	}
}
