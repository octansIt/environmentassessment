namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasHostRecommendation : DynamicData
	{
		protected ManagedObjectReference _host;
		protected int? _drsRating;
		protected ClusterDasHostRecommendation_LinkedView _linkedView;
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
		public int? DrsRating
		{
			get
			{
				return this._drsRating;
			}
			set
			{
				this._drsRating = value;
			}
		}
		public ClusterDasHostRecommendation_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
