namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineConsolePreferences : DynamicData
	{
		protected bool? _powerOnWhenOpened;
		protected bool? _enterFullScreenOnPowerOn;
		protected bool? _closeOnPowerOffOrSuspend;
		public bool? PowerOnWhenOpened
		{
			get
			{
				return this._powerOnWhenOpened;
			}
			set
			{
				this._powerOnWhenOpened = value;
			}
		}
		public bool? EnterFullScreenOnPowerOn
		{
			get
			{
				return this._enterFullScreenOnPowerOn;
			}
			set
			{
				this._enterFullScreenOnPowerOn = value;
			}
		}
		public bool? CloseOnPowerOffOrSuspend
		{
			get
			{
				return this._closeOnPowerOffOrSuspend;
			}
			set
			{
				this._closeOnPowerOffOrSuspend = value;
			}
		}
	}
}
