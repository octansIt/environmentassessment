namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileMetadata : DynamicData
	{
		protected string _key;
		protected string _profileTypeName;
		protected ExtendedDescription _description;
		protected ProfileMetadataProfileSortSpec[] _sortSpec;
		protected string _profileCategory;
		protected string _profileComponent;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string ProfileTypeName
		{
			get
			{
				return this._profileTypeName;
			}
			set
			{
				this._profileTypeName = value;
			}
		}
		public ExtendedDescription Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public ProfileMetadataProfileSortSpec[] SortSpec
		{
			get
			{
				return this._sortSpec;
			}
			set
			{
				this._sortSpec = value;
			}
		}
		public string ProfileCategory
		{
			get
			{
				return this._profileCategory;
			}
			set
			{
				this._profileCategory = value;
			}
		}
		public string ProfileComponent
		{
			get
			{
				return this._profileComponent;
			}
			set
			{
				this._profileComponent = value;
			}
		}
	}
}
