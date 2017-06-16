namespace EnvironmentAssessment.Common.VISoap
{
    public class LicenseUsageInfo : DynamicData
	{
		protected LicenseSource _source;
		protected bool _sourceAvailable;
		protected LicenseReservationInfo[] _reservationInfo;
		protected LicenseFeatureInfo[] _featureInfo;
		public LicenseSource Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public bool SourceAvailable
		{
			get
			{
				return this._sourceAvailable;
			}
			set
			{
				this._sourceAvailable = value;
			}
		}
		public LicenseReservationInfo[] ReservationInfo
		{
			get
			{
				return this._reservationInfo;
			}
			set
			{
				this._reservationInfo = value;
			}
		}
		public LicenseFeatureInfo[] FeatureInfo
		{
			get
			{
				return this._featureInfo;
			}
			set
			{
				this._featureInfo = value;
			}
		}
	}
}
