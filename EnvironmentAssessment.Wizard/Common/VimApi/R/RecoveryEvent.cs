namespace EnvironmentAssessment.Common.VimApi
{
	public class RecoveryEvent : DvsEvent
	{
		protected string _hostName;
		protected string _portKey;
		protected string _dvsUuid;
		protected string _vnic;
		public string HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
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
		public string DvsUuid
		{
			get
			{
				return this._dvsUuid;
			}
			set
			{
				this._dvsUuid = value;
			}
		}
		public string Vnic
		{
			get
			{
				return this._vnic;
			}
			set
			{
				this._vnic = value;
			}
		}
	}
}
