namespace EnvironmentAssessment.Common.VimApi
{
	public class NonVmwareOuiMacNotSupportedHost : NotSupportedHost
	{
		protected string _hostName;
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
	}
}
