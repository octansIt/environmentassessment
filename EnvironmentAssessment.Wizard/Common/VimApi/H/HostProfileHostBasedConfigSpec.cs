namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfileHostBasedConfigSpec : HostProfileConfigSpec
	{
		protected ManagedObjectReference _host;
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
