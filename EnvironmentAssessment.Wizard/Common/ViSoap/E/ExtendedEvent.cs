namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtendedEvent : GeneralEvent
	{
		protected string _eventTypeId;
		protected ManagedObjectReference _managedObject;
		protected ExtendedEventPair[] _data;
		public string EventTypeId
		{
			get
			{
				return this._eventTypeId;
			}
			set
			{
				this._eventTypeId = value;
			}
		}
		public ManagedObjectReference ManagedObject
		{
			get
			{
				return this._managedObject;
			}
			set
			{
				this._managedObject = value;
			}
		}
		public ExtendedEventPair[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
	}
}
