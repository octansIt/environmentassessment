namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileProfileStructure : DynamicData
	{
		protected string _profileTypeName;
		protected ProfileProfileStructureProperty[] _child;
		protected HostProfileMapping[] _mapping;
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
		public ProfileProfileStructureProperty[] Child
		{
			get
			{
				return this._child;
			}
			set
			{
				this._child = value;
			}
		}
		public HostProfileMapping[] Mapping
		{
			get
			{
				return this._mapping;
			}
			set
			{
				this._mapping = value;
			}
		}
	}
}
