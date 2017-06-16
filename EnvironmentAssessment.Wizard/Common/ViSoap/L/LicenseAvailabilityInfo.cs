namespace EnvironmentAssessment.Common.VISoap
{
    public class LicenseAvailabilityInfo : DynamicData
	{
		protected LicenseFeatureInfo _feature;
		protected int _total;
		protected int _available;
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
		public int Total
		{
			get
			{
				return this._total;
			}
			set
			{
				this._total = value;
			}
		}
		public int Available
		{
			get
			{
				return this._available;
			}
			set
			{
				this._available = value;
			}
		}
	}
}
