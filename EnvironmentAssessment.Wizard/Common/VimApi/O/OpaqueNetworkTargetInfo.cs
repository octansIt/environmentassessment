namespace EnvironmentAssessment.Common.VimApi
{
	public class OpaqueNetworkTargetInfo : VirtualMachineTargetInfo
	{
		protected OpaqueNetworkSummary _network;
		protected bool? _networkReservationSupported;
		public OpaqueNetworkSummary Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public bool? NetworkReservationSupported
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
