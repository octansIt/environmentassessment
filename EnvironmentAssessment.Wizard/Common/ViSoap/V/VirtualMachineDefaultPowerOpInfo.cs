namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineDefaultPowerOpInfo : DynamicData
	{
		protected string _powerOffType;
		protected string _suspendType;
		protected string _resetType;
		protected string _defaultPowerOffType;
		protected string _defaultSuspendType;
		protected string _defaultResetType;
		protected string _standbyAction;
		public string PowerOffType
		{
			get
			{
				return this._powerOffType;
			}
			set
			{
				this._powerOffType = value;
			}
		}
		public string SuspendType
		{
			get
			{
				return this._suspendType;
			}
			set
			{
				this._suspendType = value;
			}
		}
		public string ResetType
		{
			get
			{
				return this._resetType;
			}
			set
			{
				this._resetType = value;
			}
		}
		public string DefaultPowerOffType
		{
			get
			{
				return this._defaultPowerOffType;
			}
			set
			{
				this._defaultPowerOffType = value;
			}
		}
		public string DefaultSuspendType
		{
			get
			{
				return this._defaultSuspendType;
			}
			set
			{
				this._defaultSuspendType = value;
			}
		}
		public string DefaultResetType
		{
			get
			{
				return this._defaultResetType;
			}
			set
			{
				this._defaultResetType = value;
			}
		}
		public string StandbyAction
		{
			get
			{
				return this._standbyAction;
			}
			set
			{
				this._standbyAction = value;
			}
		}
	}
}
