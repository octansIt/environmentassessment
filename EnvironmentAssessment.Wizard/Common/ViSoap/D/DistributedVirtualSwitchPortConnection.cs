namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitchPortConnection : DynamicData
	{
		protected string _switchUuid;
		protected string _portgroupKey;
		protected string _portKey;
		protected int? _connectionCookie;
		public string SwitchUuid
		{
			get
			{
				return this._switchUuid;
			}
			set
			{
				this._switchUuid = value;
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
		public int? ConnectionCookie
		{
			get
			{
				return this._connectionCookie;
			}
			set
			{
				this._connectionCookie = value;
			}
		}
	}
}
