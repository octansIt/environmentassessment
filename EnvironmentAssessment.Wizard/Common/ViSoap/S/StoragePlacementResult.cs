namespace EnvironmentAssessment.Common.VISoap
{
    public class StoragePlacementResult : DynamicData
	{
		protected ClusterRecommendation[] _recommendations;
		protected ClusterDrsFaults _drsFault;
		protected ManagedObjectReference _task;
		protected StoragePlacementResult_LinkedView _linkedView;
		public ClusterRecommendation[] Recommendations
		{
			get
			{
				return this._recommendations;
			}
			set
			{
				this._recommendations = value;
			}
		}
		public ClusterDrsFaults DrsFault
		{
			get
			{
				return this._drsFault;
			}
			set
			{
				this._drsFault = value;
			}
		}
		public ManagedObjectReference Task
		{
			get
			{
				return this._task;
			}
			set
			{
				this._task = value;
			}
		}
		public StoragePlacementResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
