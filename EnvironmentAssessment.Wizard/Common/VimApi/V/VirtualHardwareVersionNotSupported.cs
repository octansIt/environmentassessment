namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualHardwareVersionNotSupported : VirtualHardwareCompatibilityIssue
	{
		protected string _hostName;
		protected ManagedObjectReference _host;
		protected VirtualHardwareVersionNotSupported_LinkedView _linkedView;
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
		public VirtualHardwareVersionNotSupported_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
