namespace EnvironmentAssessment.Common.VimApi
{
	public class EVCUnsupportedByHostHardware : EVCConfigFault
	{
		protected ManagedObjectReference[] _host;
		protected string[] _hostName;
		protected EVCUnsupportedByHostHardware_LinkedView _linkedView;
		public ManagedObjectReference[] Host
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
		public string[] HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
		public EVCUnsupportedByHostHardware_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
