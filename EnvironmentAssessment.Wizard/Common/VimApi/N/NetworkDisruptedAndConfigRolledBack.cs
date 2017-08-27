namespace EnvironmentAssessment.Common.VimApi
{
	public class NetworkDisruptedAndConfigRolledBack : VimFault
	{
		protected string _host;
		public string Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
	}
}
