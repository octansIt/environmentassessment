namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasVmConfigInfo_LinkedView
	{
		protected VirtualMachine _key;
		protected VirtualMachineSnapshot _goldenSnapshot;
		public VirtualMachine Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public VirtualMachineSnapshot GoldenSnapshot
		{
			get
			{
				return this._goldenSnapshot;
			}
			set
			{
				this._goldenSnapshot = value;
			}
		}
	}
}
