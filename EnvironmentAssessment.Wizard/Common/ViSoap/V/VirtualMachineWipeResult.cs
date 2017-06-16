namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineWipeResult : DynamicData
	{
		protected int _diskId;
		protected long _shrinkableDiskSpace;
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
		public long ShrinkableDiskSpace
		{
			get
			{
				return this._shrinkableDiskSpace;
			}
			set
			{
				this._shrinkableDiskSpace = value;
			}
		}
	}
}
