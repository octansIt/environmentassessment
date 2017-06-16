namespace EnvironmentAssessment.Common.VISoap
{
    public class EventDescription : DynamicData
	{
		protected ElementDescription[] _category;
		protected EventDescriptionEventDetail[] _eventInfo;
		protected EnumDescription[] _enumeratedTypes;
		public ElementDescription[] Category
		{
			get
			{
				return this._category;
			}
			set
			{
				this._category = value;
			}
		}
		public EventDescriptionEventDetail[] EventInfo
		{
			get
			{
				return this._eventInfo;
			}
			set
			{
				this._eventInfo = value;
			}
		}
		public EnumDescription[] EnumeratedTypes
		{
			get
			{
				return this._enumeratedTypes;
			}
			set
			{
				this._enumeratedTypes = value;
			}
		}
	}
}
