namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseExpiredEvent : Event
	{
		protected LicenseFeatureInfo _feature;
		public LicenseFeatureInfo Feature
		{
			get
			{
				return this._feature;
			}
			set
			{
				this._feature = value;
			}
		}
	}
}
