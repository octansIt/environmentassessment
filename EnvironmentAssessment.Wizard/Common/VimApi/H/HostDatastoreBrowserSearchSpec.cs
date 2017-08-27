namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDatastoreBrowserSearchSpec : DynamicData
	{
		protected FileQuery[] _query;
		protected FileQueryFlags _details;
		protected bool? _searchCaseInsensitive;
		protected string[] _matchPattern;
		protected bool? _sortFoldersFirst;
		public FileQuery[] Query
		{
			get
			{
				return this._query;
			}
			set
			{
				this._query = value;
			}
		}
		public FileQueryFlags Details
		{
			get
			{
				return this._details;
			}
			set
			{
				this._details = value;
			}
		}
		public bool? SearchCaseInsensitive
		{
			get
			{
				return this._searchCaseInsensitive;
			}
			set
			{
				this._searchCaseInsensitive = value;
			}
		}
		public string[] MatchPattern
		{
			get
			{
				return this._matchPattern;
			}
			set
			{
				this._matchPattern = value;
			}
		}
		public bool? SortFoldersFirst
		{
			get
			{
				return this._sortFoldersFirst;
			}
			set
			{
				this._sortFoldersFirst = value;
			}
		}
	}
}
