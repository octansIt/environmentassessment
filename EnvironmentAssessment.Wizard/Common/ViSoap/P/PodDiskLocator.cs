namespace EnvironmentAssessment.Common.VISoap
{
    public class PodDiskLocator : DynamicData
	{
		protected int _diskId;
		protected string _diskMoveType;
		protected VirtualDeviceBackingInfo _diskBackingInfo;
		protected VirtualMachineProfileSpec[] _profile;
		public int DiskId
		{
			get
			{
				return this._diskId;
			}
			set
			{
				this._diskId = value;
			}
		}
		public string DiskMoveType
		{
			get
			{
				return this._diskMoveType;
			}
			set
			{
				this._diskMoveType = value;
			}
		}
		public VirtualDeviceBackingInfo DiskBackingInfo
		{
			get
			{
				return this._diskBackingInfo;
			}
			set
			{
				this._diskBackingInfo = value;
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
