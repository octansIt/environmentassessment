namespace EnvironmentAssessment.Common.VimApi
{
	public class ReplicationVmInProgressFault : ReplicationVmFault
	{
		protected string _requestedActivity;
		protected string _inProgressActivity;
		public string RequestedActivity
		{
			get
			{
				return this._requestedActivity;
			}
			set
			{
				this._requestedActivity = value;
			}
		}
		public string InProgressActivity
		{
			get
			{
				return this._inProgressActivity;
			}
			set
			{
				this._inProgressActivity = value;
			}
		}
		public new ReplicationVmInProgressFault_LinkedView LinkedView
		{
			get
			{
				return (ReplicationVmInProgressFault_LinkedView)this._linkedView;
			}
		}
	}
}
