namespace EnvironmentAssessment.Common.VimApi
{
	public class ActiveVMsBlockingEVC : EVCConfigFault
	{
		protected string _evcMode;
		protected ManagedObjectReference[] _host;
		protected string[] _hostName;
		protected ActiveVMsBlockingEVC_LinkedView _linkedView;
		public string EvcMode
		{
			get
			{
				return this._evcMode;
			}
			set
			{
				this._evcMode = value;
			}
		}
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
		public ActiveVMsBlockingEVC_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
