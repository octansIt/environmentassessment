namespace EnvironmentAssessment.Common.VISoap
{
    public class AutoStartPowerInfo : DynamicData
	{
		protected ManagedObjectReference _key;
		protected int _startOrder;
		protected int _startDelay;
		protected AutoStartWaitHeartbeatSetting _waitForHeartbeat;
		protected string _startAction;
		protected int _stopDelay;
		protected string _stopAction;
		protected AutoStartPowerInfo_LinkedView _linkedView;
		public ManagedObjectReference Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public int StartOrder
		{
			get
			{
				return this._startOrder;
			}
			set
			{
				this._startOrder = value;
			}
		}
		public int StartDelay
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
		public AutoStartWaitHeartbeatSetting WaitForHeartbeat
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
		public string StartAction
		{
			get
			{
				return this._startAction;
			}
			set
			{
				this._startAction = value;
			}
		}
		public int StopDelay
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
		public AutoStartPowerInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
