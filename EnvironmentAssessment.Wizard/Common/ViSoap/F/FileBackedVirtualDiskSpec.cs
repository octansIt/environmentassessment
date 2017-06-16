namespace EnvironmentAssessment.Common.VISoap
{
    public class FileBackedVirtualDiskSpec : VirtualDiskSpec
	{
		protected long _capacityKb;
		protected VirtualMachineProfileSpec[] _profile;
		public long CapacityKb
		{
			get
			{
				return this._capacityKb;
			}
			set
			{
				this._capacityKb = value;
			}
		}
		public VirtualMachineProfileSpec[] Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
			}
		}
	}
}
