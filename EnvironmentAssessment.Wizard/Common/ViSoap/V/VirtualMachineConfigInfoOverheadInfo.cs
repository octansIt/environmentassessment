namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineConfigInfoOverheadInfo : DynamicData
	{
		protected long? _initialMemoryReservation;
		protected long? _initialSwapReservation;
		public long? InitialMemoryReservation
		{
			get
			{
				return this._initialMemoryReservation;
			}
			set
			{
				this._initialMemoryReservation = value;
			}
		}
		public long? InitialSwapReservation
		{
			get
			{
				return this._initialSwapReservation;
			}
			set
			{
				this._initialSwapReservation = value;
			}
		}
	}
}
