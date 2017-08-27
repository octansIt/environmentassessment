namespace EnvironmentAssessment.Common.VimApi
{
	public class ExtensionEventTypeInfo : DynamicData
	{
		protected string _eventID;
		protected string _eventTypeSchema;
		public string EventID
		{
			get
			{
				return this._eventID;
			}
			set
			{
				this._eventID = value;
			}
		}
		public string EventTypeSchema
		{
			get
			{
				return this._eventTypeSchema;
			}
			set
			{
				this._eventTypeSchema = value;
			}
		}
	}
}
