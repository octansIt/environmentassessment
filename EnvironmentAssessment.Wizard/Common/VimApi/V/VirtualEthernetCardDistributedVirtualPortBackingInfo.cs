namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualEthernetCardDistributedVirtualPortBackingInfo : VirtualDeviceBackingInfo
	{
		protected DistributedVirtualSwitchPortConnection _port;
		public DistributedVirtualSwitchPortConnection Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
	}
}
