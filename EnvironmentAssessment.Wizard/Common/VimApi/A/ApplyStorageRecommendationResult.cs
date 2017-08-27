namespace EnvironmentAssessment.Common.VimApi
{
	public class ApplyStorageRecommendationResult : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected ApplyStorageRecommendationResult_LinkedView _linkedView;
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public ApplyStorageRecommendationResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
