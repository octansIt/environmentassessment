namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppCloneSpec_LinkedView
	{
		protected Datastore _location;
		protected HostSystem _host;
		protected Folder _vmFolder;
		public Datastore Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}
		public HostSystem Host
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
		public Folder VmFolder
		{
			get
			{
				return this._vmFolder;
			}
			set
			{
				this._vmFolder = value;
			}
		}
	}
}
