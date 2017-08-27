namespace EnvironmentAssessment.Common.VimApi
{
	public class QuiesceDatastoreIOForHAFailed : ResourceInUse
	{
		protected ManagedObjectReference _host;
		protected string _hostName;
		protected ManagedObjectReference _ds;
		protected string _dsName;
		protected QuiesceDatastoreIOForHAFailed_LinkedView _linkedView;
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
		public ManagedObjectReference Ds
		{
			get
			{
				return this._ds;
			}
			set
			{
				this._ds = value;
			}
		}
		public string DsName
		{
			get
			{
				return this._dsName;
			}
			set
			{
				this._dsName = value;
			}
		}
		public QuiesceDatastoreIOForHAFailed_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
