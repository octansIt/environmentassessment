namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiTargetTransport : HostTargetTransport
	{
		protected string _iScsiName;
		protected string _iScsiAlias;
		protected string[] _address;
		public string IScsiName
		{
			get
			{
				return this._iScsiName;
			}
			set
			{
				this._iScsiName = value;
			}
		}
		public string IScsiAlias
		{
			get
			{
				return this._iScsiAlias;
			}
			set
			{
				this._iScsiAlias = value;
			}
		}
		public string[] Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}
	}
}
