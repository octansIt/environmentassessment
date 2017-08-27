namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualEthernetCardNetworkBackingInfo_LinkedView
	{
		protected Network _network;
		public Network Network
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
	}
}
