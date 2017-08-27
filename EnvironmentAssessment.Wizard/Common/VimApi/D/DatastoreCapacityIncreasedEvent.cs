namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastoreCapacityIncreasedEvent : DatastoreEvent
	{
		protected long _oldCapacity;
		protected long _newCapacity;
		public long OldCapacity
		{
			get
			{
				return this._oldCapacity;
			}
			set
			{
				this._oldCapacity = value;
			}
		}
		public long NewCapacity
		{
			get
			{
				return this._newCapacity;
			}
			set
			{
				this._newCapacity = value;
			}
		}
	}
}
