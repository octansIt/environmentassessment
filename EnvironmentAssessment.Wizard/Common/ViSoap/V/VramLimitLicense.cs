namespace EnvironmentAssessment.Common.VISoap
{
    public class VramLimitLicense : NotEnoughLicenses
	{
		protected int _limit;
		public int Limit
		{
			get
			{
				return this._limit;
			}
			set
			{
				this._limit = value;
			}
		}
	}
}
