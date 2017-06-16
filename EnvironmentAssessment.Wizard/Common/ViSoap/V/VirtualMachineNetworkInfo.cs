namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineNetworkInfo : VirtualMachineTargetInfo
	{
		protected NetworkSummary _network;
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
	}
}
