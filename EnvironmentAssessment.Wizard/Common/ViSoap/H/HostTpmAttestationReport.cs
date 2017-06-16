namespace EnvironmentAssessment.Common.VISoap
{
    public class HostTpmAttestationReport : DynamicData
	{
		protected HostTpmDigestInfo[] _tpmPcrValues;
		protected HostTpmEventLogEntry[] _tpmEvents;
		protected bool _tpmLogReliable;
		public HostTpmDigestInfo[] TpmPcrValues
		{
			get
			{
				return this._tpmPcrValues;
			}
			set
			{
				this._tpmPcrValues = value;
			}
		}
		public HostTpmEventLogEntry[] TpmEvents
		{
			get
			{
				return this._tpmEvents;
			}
			set
			{
				this._tpmEvents = value;
			}
		}
		public bool TpmLogReliable
		{
			get
			{
				return this._tpmLogReliable;
			}
			set
			{
				this._tpmLogReliable = value;
			}
		}
	}
}
