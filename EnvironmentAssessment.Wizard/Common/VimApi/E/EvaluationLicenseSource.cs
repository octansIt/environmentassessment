namespace EnvironmentAssessment.Common.VimApi
{
	public class EvaluationLicenseSource : LicenseSource
	{
		protected long? _remainingHours;
		public long? RemainingHours
		{
			get
			{
				return this._remainingHours;
			}
			set
			{
				this._remainingHours = value;
			}
		}
	}
}
