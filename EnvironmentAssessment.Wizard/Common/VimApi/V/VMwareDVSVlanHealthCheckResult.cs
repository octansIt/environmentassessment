namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDVSVlanHealthCheckResult : HostMemberUplinkHealthCheckResult
	{
		protected NumericRange[] _trunkedVlan;
		protected NumericRange[] _untrunkedVlan;
		public NumericRange[] TrunkedVlan
		{
			get
			{
				return this._trunkedVlan;
			}
			set
			{
				this._trunkedVlan = value;
			}
		}
		public NumericRange[] UntrunkedVlan
		{
			get
			{
				return this._untrunkedVlan;
			}
			set
			{
				this._untrunkedVlan = value;
			}
		}
	}
}
