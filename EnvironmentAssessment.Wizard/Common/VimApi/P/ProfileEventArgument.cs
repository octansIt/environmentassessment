namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileEventArgument : EventArgument
	{
		protected ManagedObjectReference _profile;
		protected string _name;
		protected ProfileEventArgument_LinkedView _linkedView;
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
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public ProfileEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
