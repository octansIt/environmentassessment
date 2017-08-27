namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemUpgradeHistoryItem_LinkedView
	{
		protected HostSystem _host;
		protected Task _task;
		public HostSystem Host
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
		public Task Task
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
	}
}
