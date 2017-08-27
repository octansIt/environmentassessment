namespace EnvironmentAssessment.Common.VimApi
{
	public class HostUnresolvedVmfsResignatureSpec : DynamicData
	{
		protected string[] _extentDevicePath;
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
	}
}
