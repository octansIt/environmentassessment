namespace EnvironmentAssessment.Common.VISoap
{
    public class MultipleCertificatesVerifyFaultThumbprintData : DynamicData
	{
		protected int _port;
		protected string _thumbprint;
		public int Port
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
