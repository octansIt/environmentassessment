namespace EnvironmentAssessment.Common.VimApi
{
	public class PodStorageDrsEntry : DynamicData
	{
		protected StorageDrsConfigInfo _storageDrsConfig;
		protected ClusterRecommendation[] _recommendation;
		protected ClusterDrsFaults[] _drsFault;
		protected ClusterActionHistory[] _actionHistory;
		public StorageDrsConfigInfo StorageDrsConfig
		{
			get
			{
				return this._storageDrsConfig;
			}
			set
			{
				this._storageDrsConfig = value;
			}
		}
		public ClusterRecommendation[] Recommendation
		{
			get
			{
				return this._recommendation;
			}
			set
			{
				this._recommendation = value;
			}
		}
		public ClusterDrsFaults[] DrsFault
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
		public ClusterActionHistory[] ActionHistory
		{
			get
			{
				return this._actionHistory;
			}
			set
			{
				this._actionHistory = value;
			}
		}
	}
}
