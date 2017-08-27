namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfUnsupportedDiskProvisioning : OvfImport
	{
		protected string _diskProvisioning;
		protected string _supportedDiskProvisioning;
		public string DiskProvisioning
		{
			get
			{
				return this._diskProvisioning;
			}
			set
			{
				this._diskProvisioning = value;
			}
		}
		public string SupportedDiskProvisioning
		{
			get
			{
				return this._supportedDiskProvisioning;
			}
			set
			{
				this._supportedDiskProvisioning = value;
			}
		}
	}
}
