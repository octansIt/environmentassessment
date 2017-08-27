namespace EnvironmentAssessment.Common.VimApi
{
	public class HostTpmEventLogEntry : DynamicData
	{
		protected int _pcrIndex;
		protected HostTpmEventDetails _eventDetails;
		public int PcrIndex
		{
			get
			{
				return this._pcrIndex;
			}
			set
			{
				this._pcrIndex = value;
			}
		}
		public HostTpmEventDetails EventDetails
		{
			get
			{
				return this._eventDetails;
			}
			set
			{
				this._eventDetails = value;
			}
		}
	}
}
