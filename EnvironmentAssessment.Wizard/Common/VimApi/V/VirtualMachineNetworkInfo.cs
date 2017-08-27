namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineNetworkInfo : VirtualMachineTargetInfo
	{
		protected NetworkSummary _network;
		protected string _vswitch;
		public NetworkSummary Network
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
		public string Vswitch
		{
			get
			{
				return this._vswitch;
			}
			set
			{
				this._vswitch = value;
			}
		}
	}
}
