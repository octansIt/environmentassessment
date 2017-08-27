namespace EnvironmentAssessment.Common.VimApi
{
	public class VmLimitLicense : NotEnoughLicenses
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
