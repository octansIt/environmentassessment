namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualEthernetCardNetworkBackingInfo : VirtualDeviceDeviceBackingInfo
	{
		protected ManagedObjectReference _network;
		protected bool? _inPassthroughMode;
		protected VirtualEthernetCardNetworkBackingInfo_LinkedView _linkedView;
		public ManagedObjectReference Network
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
		public bool? InPassthroughMode
		{
			get
			{
				return this._inPassthroughMode;
			}
			set
			{
				this._inPassthroughMode = value;
			}
		}
		public VirtualEthernetCardNetworkBackingInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
