namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsPortLeavePortgroupEvent : DvsEvent
	{
		protected string _portKey;
		protected string _portgroupKey;
		protected string _portgroupName;
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
		public string PortgroupKey
		{
			get
			{
				return this._portgroupKey;
			}
			set
			{
				this._portgroupKey = value;
			}
		}
		public string PortgroupName
		{
			get
			{
				return this._portgroupName;
			}
			set
			{
				this._portgroupName = value;
			}
		}
	}
}
