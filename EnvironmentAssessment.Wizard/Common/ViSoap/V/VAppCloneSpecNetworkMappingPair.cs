namespace EnvironmentAssessment.Common.VISoap
{
    public class VAppCloneSpecNetworkMappingPair : DynamicData
	{
		protected ManagedObjectReference _source;
		protected ManagedObjectReference _destination;
		protected VAppCloneSpecNetworkMappingPair_LinkedView _linkedView;
		public ManagedObjectReference Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public ManagedObjectReference Destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				this._destination = value;
			}
		}
		public VAppCloneSpecNetworkMappingPair_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
