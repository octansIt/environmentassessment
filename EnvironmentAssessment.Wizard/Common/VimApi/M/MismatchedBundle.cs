namespace EnvironmentAssessment.Common.VimApi
{
	public class MismatchedBundle : VimFault
	{
		protected string _bundleUuid;
		protected string _hostUuid;
		protected int _bundleBuildNumber;
		protected int _hostBuildNumber;
		public string BundleUuid
		{
			get
			{
				return this._bundleUuid;
			}
			set
			{
				this._bundleUuid = value;
			}
		}
		public string HostUuid
		{
			get
			{
				return this._hostUuid;
			}
			set
			{
				this._hostUuid = value;
			}
		}
		public int BundleBuildNumber
		{
			get
			{
				return this._bundleBuildNumber;
			}
			set
			{
				this._bundleBuildNumber = value;
			}
		}
		public int HostBuildNumber
		{
			get
			{
				return this._hostBuildNumber;
			}
			set
			{
				this._hostBuildNumber = value;
			}
		}
	}
}
