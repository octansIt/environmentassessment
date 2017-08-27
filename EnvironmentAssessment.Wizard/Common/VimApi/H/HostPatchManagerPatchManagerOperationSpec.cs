namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPatchManagerPatchManagerOperationSpec : DynamicData
	{
		protected string _proxy;
		protected int? _port;
		protected string _userName;
		protected string _password;
		protected string _cmdOption;
		public string Proxy
		{
			get
			{
				return this._proxy;
			}
			set
			{
				this._proxy = value;
			}
		}
		public int? Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
		public string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				this._userName = value;
			}
		}
		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				this._password = value;
			}
		}
		public string CmdOption
		{
			get
			{
				return this._cmdOption;
			}
			set
			{
				this._cmdOption = value;
			}
		}
	}
}
