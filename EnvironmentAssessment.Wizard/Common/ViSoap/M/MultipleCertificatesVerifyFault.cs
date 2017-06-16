namespace EnvironmentAssessment.Common.VISoap
{
    public class MultipleCertificatesVerifyFault : HostConnectFault
	{
		protected MultipleCertificatesVerifyFaultThumbprintData[] _thumbprintData;
		public MultipleCertificatesVerifyFaultThumbprintData[] ThumbprintData
		{
			get
			{
				return this._thumbprintData;
			}
			set
			{
				this._thumbprintData = value;
			}
		}
	}
}
