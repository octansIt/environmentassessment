namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineIdeDiskDevicePartitionInfo : DynamicData
	{
		protected int _id;
		protected int _capacity;
		public int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public int Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				this._capacity = value;
			}
		}
	}
}
