namespace EnvironmentAssessment.Common.VimApi
{
	public class CannotEnableVmcpForCluster : VimFault
	{
		protected ManagedObjectReference _host;
		protected string _hostName;
		protected string _reason;
		protected CannotEnableVmcpForCluster_LinkedView _linkedView;
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
		public string HostName
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
		public CannotEnableVmcpForCluster_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
