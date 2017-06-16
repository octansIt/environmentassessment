namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestDiskInfo : DynamicData
	{
		protected string _diskPath;
		protected long? _capacity;
		protected long? _freeSpace;
		public string DiskPath
		{
			get
			{
				return this._diskPath;
			}
			set
			{
				this._diskPath = value;
			}
		}
		public long? Capacity
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
		public long? FreeSpace
		{
			get
			{
				return this._freeSpace;
			}
			set
			{
				this._freeSpace = value;
			}
		}
	}
}
