namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidProfileReferenceHost : RuntimeFault
	{
		protected string _reason;
		protected ManagedObjectReference _host;
		protected ManagedObjectReference _profile;
		protected string _profileName;
		protected InvalidProfileReferenceHost_LinkedView _linkedView;
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
		public ManagedObjectReference Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
			}
		}
		public string ProfileName
		{
			get
			{
				return this._profileName;
			}
			set
			{
				this._profileName = value;
			}
		}
		public InvalidProfileReferenceHost_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
