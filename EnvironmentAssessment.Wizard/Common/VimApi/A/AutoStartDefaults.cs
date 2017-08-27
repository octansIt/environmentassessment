namespace EnvironmentAssessment.Common.VimApi
{
	public class AutoStartDefaults : DynamicData
	{
		protected bool? _enabled;
		protected int? _startDelay;
		protected int? _stopDelay;
		protected bool? _waitForHeartbeat;
		protected string _stopAction;
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public int? StartDelay
		{
			get
			{
				return this._startDelay;
			}
			set
			{
				this._startDelay = value;
			}
		}
		public int? StopDelay
		{
			get
			{
				return this._stopDelay;
			}
			set
			{
				this._stopDelay = value;
			}
		}
		public bool? WaitForHeartbeat
		{
			get
			{
				return this._waitForHeartbeat;
			}
			set
			{
				this._waitForHeartbeat = value;
			}
		}
		public string StopAction
		{
			get
			{
				return this._stopAction;
			}
			set
			{
				this._stopAction = value;
			}
		}
	}
}
