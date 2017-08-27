namespace EnvironmentAssessment.Common.VimApi
{
	public class UpdateSet : DynamicData
	{
		protected string _version;
		protected PropertyFilterUpdate[] _filterSet;
		protected bool? _truncated;
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
		public PropertyFilterUpdate[] FilterSet
		{
			get
			{
				return this._filterSet;
			}
			set
			{
				this._filterSet = value;
			}
		}
		public bool? Truncated
		{
			get
			{
				return this._truncated;
			}
			set
			{
				this._truncated = value;
			}
		}
	}
}
