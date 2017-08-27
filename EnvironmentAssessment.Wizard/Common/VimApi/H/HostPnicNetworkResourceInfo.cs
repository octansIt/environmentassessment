namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPnicNetworkResourceInfo : DynamicData
	{
		protected string _pnicDevice;
		protected long? _availableBandwidthForVMTraffic;
		protected long? _unusedBandwidthForVMTraffic;
		protected HostPlacedVirtualNicIdentifier[] _placedVirtualNics;
		public string PnicDevice
		{
			get
			{
				return this._pnicDevice;
			}
			set
			{
				this._pnicDevice = value;
			}
		}
		public long? AvailableBandwidthForVMTraffic
		{
			get
			{
				return this._availableBandwidthForVMTraffic;
			}
			set
			{
				this._availableBandwidthForVMTraffic = value;
			}
		}
		public long? UnusedBandwidthForVMTraffic
		{
			get
			{
				return this._unusedBandwidthForVMTraffic;
			}
			set
			{
				this._unusedBandwidthForVMTraffic = value;
			}
		}
		public HostPlacedVirtualNicIdentifier[] PlacedVirtualNics
		{
			get
			{
				return this._placedVirtualNics;
			}
			set
			{
				this._placedVirtualNics = value;
			}
		}
	}
}
