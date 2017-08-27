namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementRankSpec : DynamicData
	{
		protected PlacementSpec[] _specs;
		protected ManagedObjectReference[] _clusters;
		protected PlacementAffinityRule[] _rules;
		protected StorageDrsPlacementRankVmSpec[] _placementRankByVm;
		protected PlacementRankSpec_LinkedView _linkedView;
		public PlacementSpec[] Specs
		{
			get
			{
				return this._specs;
			}
			set
			{
				this._specs = value;
			}
		}
		public ManagedObjectReference[] Clusters
		{
			get
			{
				return this._clusters;
			}
			set
			{
				this._clusters = value;
			}
		}
		public PlacementAffinityRule[] Rules
		{
			get
			{
				return this._rules;
			}
			set
			{
				this._rules = value;
			}
		}
		public StorageDrsPlacementRankVmSpec[] PlacementRankByVm
		{
			get
			{
				return this._placementRankByVm;
			}
			set
			{
				this._placementRankByVm = value;
			}
		}
		public PlacementRankSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
