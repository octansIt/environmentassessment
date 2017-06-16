namespace EnvironmentAssessment.Common.VISoap
{
    public class OpaqueNetworkTargetInfo : VirtualMachineTargetInfo
	{
		protected OpaqueNetworkSummary _network;
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
	}
}
