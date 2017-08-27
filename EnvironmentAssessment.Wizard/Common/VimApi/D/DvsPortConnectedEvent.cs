namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsPortConnectedEvent : DvsEvent
	{
		protected string _portKey;
		protected DistributedVirtualSwitchPortConnectee _connectee;
		public string PortKey
		{
			get
			{
				return this._portKey;
			}
			set
			{
				this._portKey = value;
			}
		}
		public DistributedVirtualSwitchPortConnectee Connectee
		{
			get
			{
				return this._connectee;
			}
			set
			{
				this._connectee = value;
			}
		}
	}
}
