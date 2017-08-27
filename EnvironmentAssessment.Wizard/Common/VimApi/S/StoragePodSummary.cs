namespace EnvironmentAssessment.Common.VimApi
{
	public class StoragePodSummary : DynamicData
	{
		protected string _name;
		protected long _capacity;
		protected long _freeSpace;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public long Capacity
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
		public long FreeSpace
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
