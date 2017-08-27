namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileProfileStructure : DynamicData
	{
		protected string _profileTypeName;
		protected ProfileProfileStructureProperty[] _child;
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
	}
}
