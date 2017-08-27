namespace EnvironmentAssessment.Common.VimApi
{
	public class VslmCreateSpecBackingSpec : DynamicData
	{
		protected ManagedObjectReference _datastore;
		protected VslmCreateSpecBackingSpec_LinkedView _linkedView;
		public ManagedObjectReference Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public VslmCreateSpecBackingSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
