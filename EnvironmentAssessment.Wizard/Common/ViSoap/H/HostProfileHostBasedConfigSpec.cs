namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProfileHostBasedConfigSpec : HostProfileConfigSpec
	{
		protected ManagedObjectReference _host;
		protected string[] _profilesToExtract;
		protected bool? _useHostProfileEngine;
		protected HostProfileHostBasedConfigSpec_LinkedView _linkedView;
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
		public string[] ProfilesToExtract
		{
			get
			{
				return this._profilesToExtract;
			}
			set
			{
				this._profilesToExtract = value;
			}
		}
		public bool? UseHostProfileEngine
		{
			get
			{
				return this._useHostProfileEngine;
			}
			set
			{
				this._useHostProfileEngine = value;
			}
		}
		public HostProfileHostBasedConfigSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
