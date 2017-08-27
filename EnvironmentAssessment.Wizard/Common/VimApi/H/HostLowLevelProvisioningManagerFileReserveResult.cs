namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLowLevelProvisioningManagerFileReserveResult : DynamicData
	{
		protected string _baseName;
		protected string _parentDir;
		protected string _reservedName;
		public string BaseName
		{
			get
			{
				return this._baseName;
			}
			set
			{
				this._baseName = value;
			}
		}
		public string ParentDir
		{
			get
			{
				return this._parentDir;
			}
			set
			{
				this._parentDir = value;
			}
		}
		public string ReservedName
		{
			get
			{
				return this._reservedName;
			}
			set
			{
				this._reservedName = value;
			}
		}
	}
}
