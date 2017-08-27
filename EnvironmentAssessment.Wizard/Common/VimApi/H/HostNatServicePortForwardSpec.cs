namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNatServicePortForwardSpec : DynamicData
	{
		protected string _type;
		protected string _name;
		protected int _hostPort;
		protected int _guestPort;
		protected string _guestIpAddress;
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public int HostPort
		{
			get
			{
				return this._hostPort;
			}
			set
			{
				this._hostPort = value;
			}
		}
		public int GuestPort
		{
			get
			{
				return this._guestPort;
			}
			set
			{
				this._guestPort = value;
			}
		}
		public string GuestIpAddress
		{
			get
			{
				return this._guestIpAddress;
			}
			set
			{
				this._guestIpAddress = value;
			}
		}
	}
}
