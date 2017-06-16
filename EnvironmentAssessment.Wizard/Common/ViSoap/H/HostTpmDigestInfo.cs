namespace EnvironmentAssessment.Common.VISoap
{
    public class HostTpmDigestInfo : HostDigestInfo
	{
		protected int _pcrNumber;
		public int PcrNumber
		{
			get
			{
				return this._pcrNumber;
			}
			set
			{
				this._pcrNumber = value;
			}
		}
	}
}
