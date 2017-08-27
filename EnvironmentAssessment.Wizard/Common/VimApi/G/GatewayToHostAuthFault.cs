namespace EnvironmentAssessment.Common.VimApi
{
	public class GatewayToHostAuthFault : GatewayToHostConnectFault
	{
		protected string[] _invalidProperties;
		protected string[] _missingProperties;
		public string[] InvalidProperties
		{
			get
			{
				return this._invalidProperties;
			}
			set
			{
				this._invalidProperties = value;
			}
		}
		public string[] MissingProperties
		{
			get
			{
				return this._missingProperties;
			}
			set
			{
				this._missingProperties = value;
			}
		}
	}
}
