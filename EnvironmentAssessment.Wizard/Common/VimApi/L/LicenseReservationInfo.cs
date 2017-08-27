namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseReservationInfo : DynamicData
	{
		protected string _key;
		protected LicenseReservationInfoState _state;
		protected int _required;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public LicenseReservationInfoState State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public int Required
		{
			get
			{
				return this._required;
			}
			set
			{
				this._required = value;
			}
		}
	}
}
