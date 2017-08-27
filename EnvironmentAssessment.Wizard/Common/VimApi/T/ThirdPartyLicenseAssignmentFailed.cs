namespace EnvironmentAssessment.Common.VimApi
{
	public class ThirdPartyLicenseAssignmentFailed : RuntimeFault
	{
		protected ManagedObjectReference _host;
		protected string _module;
		protected string _reason;
		protected ThirdPartyLicenseAssignmentFailed_LinkedView _linkedView;
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
		public string Module
		{
			get
			{
				return this._module;
			}
			set
			{
				this._module = value;
			}
		}
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public ThirdPartyLicenseAssignmentFailed_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
