namespace EnvironmentAssessment.Common.VimApi
{
	public class NotSupportedHost : HostConnectFault
	{
		protected string _productName;
		protected string _productVersion;
		public string ProductName
		{
			get
			{
				return this._productName;
			}
			set
			{
				this._productName = value;
			}
		}
		public string ProductVersion
		{
			get
			{
				return this._productVersion;
			}
			set
			{
				this._productVersion = value;
			}
		}
	}
}
