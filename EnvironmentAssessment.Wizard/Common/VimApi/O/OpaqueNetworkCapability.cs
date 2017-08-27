namespace EnvironmentAssessment.Common.VimApi
{
	public class OpaqueNetworkCapability : DynamicData
	{
		protected bool _networkReservationSupported;
		public bool NetworkReservationSupported
		{
			get
			{
				return this._networkReservationSupported;
			}
			set
			{
				this._networkReservationSupported = value;
			}
		}
	}
}
