namespace EnvironmentAssessment.Common.VimApi
{
	public class EnvironmentBrowserConfigOptionQuerySpec : DynamicData
	{
		protected string _key;
		protected ManagedObjectReference _host;
		protected string[] _guestId;
		protected EnvironmentBrowserConfigOptionQuerySpec_LinkedView _linkedView;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
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
		public string[] GuestId
		{
			get
			{
				return this._guestId;
			}
			set
			{
				this._guestId = value;
			}
		}
		public EnvironmentBrowserConfigOptionQuerySpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
