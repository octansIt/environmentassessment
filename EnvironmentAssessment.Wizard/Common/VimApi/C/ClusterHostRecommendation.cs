namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterHostRecommendation : DynamicData
	{
		protected ManagedObjectReference _host;
		protected int _rating;
		protected ClusterHostRecommendation_LinkedView _linkedView;
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
		public int Rating
		{
			get
			{
				return this._rating;
			}
			set
			{
				this._rating = value;
			}
		}
		public ClusterHostRecommendation_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
