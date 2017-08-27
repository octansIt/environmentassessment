namespace EnvironmentAssessment.Common.VimApi
{
	public class FailToEnableSPBM : NotEnoughLicenses
	{
		protected ManagedObjectReference _cs;
		protected string _csName;
		protected ComputeResourceHostSPBMLicenseInfo[] _hostLicenseStates;
		protected FailToEnableSPBM_LinkedView _linkedView;
		public ManagedObjectReference Cs
		{
			get
			{
				return this._cs;
			}
			set
			{
				this._cs = value;
			}
		}
		public string CsName
		{
			get
			{
				return this._csName;
			}
			set
			{
				this._csName = value;
			}
		}
		public ComputeResourceHostSPBMLicenseInfo[] HostLicenseStates
		{
			get
			{
				return this._hostLicenseStates;
			}
			set
			{
				this._hostLicenseStates = value;
			}
		}
		public FailToEnableSPBM_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
