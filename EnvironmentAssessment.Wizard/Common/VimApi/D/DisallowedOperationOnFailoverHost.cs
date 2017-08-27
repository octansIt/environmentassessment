namespace EnvironmentAssessment.Common.VimApi
{
	public class DisallowedOperationOnFailoverHost : RuntimeFault
	{
		protected ManagedObjectReference _host;
		protected string _hostname;
		protected DisallowedOperationOnFailoverHost_LinkedView _linkedView;
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
		public string Hostname
		{
			get
			{
				return this._hostname;
			}
			set
			{
				this._hostname = value;
			}
		}
		public DisallowedOperationOnFailoverHost_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
