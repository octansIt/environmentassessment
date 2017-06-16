namespace EnvironmentAssessment.Common.VISoap
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
