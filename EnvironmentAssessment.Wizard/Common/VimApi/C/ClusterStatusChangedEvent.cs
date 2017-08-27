namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterStatusChangedEvent : ClusterEvent
	{
		protected string _oldStatus;
		protected string _newStatus;
		public string OldStatus
		{
			get
			{
				return this._oldStatus;
			}
			set
			{
				this._oldStatus = value;
			}
		}
		public string NewStatus
		{
			get
			{
				return this._newStatus;
			}
			set
			{
				this._newStatus = value;
			}
		}
	}
}
