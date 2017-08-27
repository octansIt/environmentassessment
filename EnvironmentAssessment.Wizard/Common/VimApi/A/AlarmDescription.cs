namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmDescription : DynamicData
	{
		protected TypeDescription[] _expr;
		protected ElementDescription[] _stateOperator;
		protected ElementDescription[] _metricOperator;
		protected ElementDescription[] _hostSystemConnectionState;
		protected ElementDescription[] _virtualMachinePowerState;
		protected ElementDescription[] _datastoreConnectionState;
		protected ElementDescription[] _hostSystemPowerState;
		protected ElementDescription[] _virtualMachineGuestHeartbeatStatus;
		protected ElementDescription[] _entityStatus;
		protected TypeDescription[] _action;
		public TypeDescription[] Expr
		{
			get
			{
				return this._expr;
			}
			set
			{
				this._expr = value;
			}
		}
		public ElementDescription[] StateOperator
		{
			get
			{
				return this._stateOperator;
			}
			set
			{
				this._stateOperator = value;
			}
		}
		public ElementDescription[] MetricOperator
		{
			get
			{
				return this._metricOperator;
			}
			set
			{
				this._metricOperator = value;
			}
		}
		public ElementDescription[] HostSystemConnectionState
		{
			get
			{
				return this._hostSystemConnectionState;
			}
			set
			{
				this._hostSystemConnectionState = value;
			}
		}
		public ElementDescription[] VirtualMachinePowerState
		{
			get
			{
				return this._virtualMachinePowerState;
			}
			set
			{
				this._virtualMachinePowerState = value;
			}
		}
		public ElementDescription[] DatastoreConnectionState
		{
			get
			{
				return this._datastoreConnectionState;
			}
			set
			{
				this._datastoreConnectionState = value;
			}
		}
		public ElementDescription[] HostSystemPowerState
		{
			get
			{
				return this._hostSystemPowerState;
			}
			set
			{
				this._hostSystemPowerState = value;
			}
		}
		public ElementDescription[] VirtualMachineGuestHeartbeatStatus
		{
			get
			{
				return this._virtualMachineGuestHeartbeatStatus;
			}
			set
			{
				this._virtualMachineGuestHeartbeatStatus = value;
			}
		}
		public ElementDescription[] EntityStatus
		{
			get
			{
				return this._entityStatus;
			}
			set
			{
				this._entityStatus = value;
			}
		}
		public TypeDescription[] Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}
	}
}
