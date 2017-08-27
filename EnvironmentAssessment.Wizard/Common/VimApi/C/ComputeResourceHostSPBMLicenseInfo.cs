namespace EnvironmentAssessment.Common.VimApi
{
	public class ComputeResourceHostSPBMLicenseInfo : DynamicData
	{
		protected ManagedObjectReference _host;
		protected ComputeResourceHostSPBMLicenseInfoHostSPBMLicenseState _licenseState;
		protected ComputeResourceHostSPBMLicenseInfo_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public ComputeResourceHostSPBMLicenseInfoHostSPBMLicenseState LicenseState
		{
			get
			{
				return this._licenseState;
			}
			set
			{
				this._licenseState = value;
			}
		}
		public ComputeResourceHostSPBMLicenseInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
