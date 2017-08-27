namespace EnvironmentAssessment.Common.VimApi
{
	public class QuarantineModeFault : VmConfigFault
	{
		protected string _vmName;
		protected string _faultType;
		public string VmName
		{
			get
			{
				return this._vmName;
			}
			set
			{
				this._vmName = value;
			}
		}
		public string FaultType
		{
			get
			{
				return this._faultType;
			}
			set
			{
				this._faultType = value;
			}
		}
	}
}
