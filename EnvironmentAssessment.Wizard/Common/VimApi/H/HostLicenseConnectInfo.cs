namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLicenseConnectInfo : DynamicData
	{
		protected LicenseManagerLicenseInfo _license;
		protected LicenseManagerEvaluationInfo _evaluation;
		protected HostLicensableResourceInfo _resource;
		public LicenseManagerLicenseInfo License
		{
			get
			{
				return this._license;
			}
			set
			{
				this._license = value;
			}
		}
		public LicenseManagerEvaluationInfo Evaluation
		{
			get
			{
				return this._evaluation;
			}
			set
			{
				this._evaluation = value;
			}
		}
		public HostLicensableResourceInfo Resource
		{
			get
			{
				return this._resource;
			}
			set
			{
				this._resource = value;
			}
		}
	}
}
