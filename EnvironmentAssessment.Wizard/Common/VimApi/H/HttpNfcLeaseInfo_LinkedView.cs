namespace EnvironmentAssessment.Common.VimApi
{
	public class HttpNfcLeaseInfo_LinkedView
	{
		protected HttpNfcLease _lease;
		protected ManagedEntity _entity;
		public HttpNfcLease Lease
		{
			get
			{
				return this._lease;
			}
			set
			{
				this._lease = value;
			}
		}
		public ManagedEntity Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
	}
}
