namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemUpgradeStatus : DynamicData
	{
		protected bool _inProgress;
		protected VsanUpgradeSystemUpgradeHistoryItem[] _history;
		protected bool? _aborted;
		protected bool? _completed;
		protected int? _progress;
		public bool InProgress
		{
			get
			{
				return this._inProgress;
			}
			set
			{
				this._inProgress = value;
			}
		}
		public VsanUpgradeSystemUpgradeHistoryItem[] History
		{
			get
			{
				return this._history;
			}
			set
			{
				this._history = value;
			}
		}
		public bool? Aborted
		{
			get
			{
				return this._aborted;
			}
			set
			{
				this._aborted = value;
			}
		}
		public bool? Completed
		{
			get
			{
				return this._completed;
			}
			set
			{
				this._completed = value;
			}
		}
		public int? Progress
		{
			get
			{
				return this._progress;
			}
			set
			{
				this._progress = value;
			}
		}
	}
}
