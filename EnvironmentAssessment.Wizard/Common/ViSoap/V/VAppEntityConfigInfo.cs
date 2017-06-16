namespace EnvironmentAssessment.Common.VISoap
{
    public class VAppEntityConfigInfo : DynamicData
	{
		protected ManagedObjectReference _key;
		protected string _tag;
		protected int? _startOrder;
		protected int? _startDelay;
		protected bool? _waitingForGuest;
		protected string _startAction;
		protected int? _stopDelay;
		protected string _stopAction;
		protected bool? _destroyWithParent;
		protected VAppEntityConfigInfo_LinkedView _linkedView;
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
		public string Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				this._tag = value;
			}
		}
		public int? StartOrder
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
		public bool? WaitingForGuest
		{
			get
			{
				return this._waitingForGuest;
			}
			set
			{
				this._waitingForGuest = value;
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
		public bool? DestroyWithParent
		{
			get
			{
				return this._destroyWithParent;
			}
			set
			{
				this._destroyWithParent = value;
			}
		}
		public VAppEntityConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
