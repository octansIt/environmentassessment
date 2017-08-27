namespace EnvironmentAssessment.Common.VimApi
{
	public class HostMemorySpec : DynamicData
	{
		protected long? _serviceConsoleReservation;
		public long? ServiceConsoleReservation
		{
			get
			{
				return this._serviceConsoleReservation;
			}
			set
			{
				this._serviceConsoleReservation = value;
			}
		}
	}
}
