namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDatastoreSystemDatastoreResult : DynamicData
	{
		protected ManagedObjectReference _key;
		protected LocalizedMethodFault _fault;
		protected HostDatastoreSystemDatastoreResult_LinkedView _linkedView;
		public ManagedObjectReference Key
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
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
		public HostDatastoreSystemDatastoreResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
