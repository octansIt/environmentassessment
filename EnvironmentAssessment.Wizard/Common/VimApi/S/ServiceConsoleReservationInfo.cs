namespace EnvironmentAssessment.Common.VimApi
{
	public class ServiceConsoleReservationInfo : DynamicData
	{
		protected long _serviceConsoleReservedCfg;
		protected long _serviceConsoleReserved;
		protected long _unreserved;
		public long ServiceConsoleReservedCfg
		{
			get
			{
				return this._serviceConsoleReservedCfg;
			}
			set
			{
				this._serviceConsoleReservedCfg = value;
			}
		}
		public long ServiceConsoleReserved
		{
			get
			{
				return this._serviceConsoleReserved;
			}
			set
			{
				this._serviceConsoleReserved = value;
			}
		}
		public long Unreserved
		{
			get
			{
				return this._unreserved;
			}
			set
			{
				this._unreserved = value;
			}
		}
	}
}
