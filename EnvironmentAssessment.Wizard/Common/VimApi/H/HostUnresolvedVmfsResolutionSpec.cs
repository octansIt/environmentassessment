namespace EnvironmentAssessment.Common.VimApi
{
	public class HostUnresolvedVmfsResolutionSpec : DynamicData
	{
		protected string[] _extentDevicePath;
		protected string _uuidResolution;
		public string[] ExtentDevicePath
		{
			get
			{
				return this._extentDevicePath;
			}
			set
			{
				this._extentDevicePath = value;
			}
		}
		public string UuidResolution
		{
			get
			{
				return this._uuidResolution;
			}
			set
			{
				this._uuidResolution = value;
			}
		}
	}
}
