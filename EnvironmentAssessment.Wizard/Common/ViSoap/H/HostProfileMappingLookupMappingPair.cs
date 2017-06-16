namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProfileMappingLookupMappingPair : DynamicData
	{
		protected string _sourcePath;
		protected string _targetProfilePath;
		public string SourcePath
		{
			get
			{
				return this._sourcePath;
			}
			set
			{
				this._sourcePath = value;
			}
		}
		public string TargetProfilePath
		{
			get
			{
				return this._targetProfilePath;
			}
			set
			{
				this._targetProfilePath = value;
			}
		}
	}
}
