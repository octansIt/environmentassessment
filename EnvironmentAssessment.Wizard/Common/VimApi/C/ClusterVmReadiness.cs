namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterVmReadiness : DynamicData
	{
		protected string _readyCondition;
		protected int? _postReadyDelay;
		public string ReadyCondition
		{
			get
			{
				return this._readyCondition;
			}
			set
			{
				this._readyCondition = value;
			}
		}
		public int? PostReadyDelay
		{
			get
			{
				return this._postReadyDelay;
			}
			set
			{
				this._postReadyDelay = value;
			}
		}
	}
}
