namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDVSMtuHealthCheckResult : HostMemberUplinkHealthCheckResult
	{
		protected bool _mtuMismatch;
		protected NumericRange[] _vlanSupportSwitchMtu;
		protected NumericRange[] _vlanNotSupportSwitchMtu;
		public bool MtuMismatch
		{
			get
			{
				return this._mtuMismatch;
			}
			set
			{
				this._mtuMismatch = value;
			}
		}
		public NumericRange[] VlanSupportSwitchMtu
		{
			get
			{
				return this._vlanSupportSwitchMtu;
			}
			set
			{
				this._vlanSupportSwitchMtu = value;
			}
		}
		public NumericRange[] VlanNotSupportSwitchMtu
		{
			get
			{
				return this._vlanNotSupportSwitchMtu;
			}
			set
			{
				this._vlanNotSupportSwitchMtu = value;
			}
		}
	}
}
