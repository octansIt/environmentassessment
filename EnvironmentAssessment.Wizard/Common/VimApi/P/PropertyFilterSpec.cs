namespace EnvironmentAssessment.Common.VimApi
{
	public class PropertyFilterSpec : DynamicData
	{
		protected PropertySpec[] _propSet;
		protected ObjectSpec[] _objectSet;
		protected bool? _reportMissingObjectsInResults;
		public PropertySpec[] PropSet
		{
			get
			{
				return this._propSet;
			}
			set
			{
				this._propSet = value;
			}
		}
		public ObjectSpec[] ObjectSet
		{
			get
			{
				return this._objectSet;
			}
			set
			{
				this._objectSet = value;
			}
		}
		public bool? ReportMissingObjectsInResults
		{
			get
			{
				return this._reportMissingObjectsInResults;
			}
			set
			{
				this._reportMissingObjectsInResults = value;
			}
		}
	}
}
