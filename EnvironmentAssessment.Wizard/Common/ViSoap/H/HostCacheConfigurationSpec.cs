namespace EnvironmentAssessment.Common.VISoap
{
    public class HostCacheConfigurationSpec : DynamicData
	{
		protected ManagedObjectReference _datastore;
		protected long _swapSize;
		protected HostCacheConfigurationSpec_LinkedView _linkedView;
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
		public long SwapSize
		{
			get
			{
				return this._swapSize;
			}
			set
			{
				this._swapSize = value;
			}
		}
		public HostCacheConfigurationSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
