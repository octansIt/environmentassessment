namespace EnvironmentAssessment.Common.VimApi
{
	public class SSLVerifyFault : HostConnectFault
	{
		protected bool _selfSigned;
		protected string _thumbprint;
		public bool SelfSigned
		{
			get
			{
				return this._selfSigned;
			}
			set
			{
				this._selfSigned = value;
			}
		}
		public string Thumbprint
		{
			get
			{
				return this._thumbprint;
			}
			set
			{
				this._thumbprint = value;
			}
		}
	}
}
