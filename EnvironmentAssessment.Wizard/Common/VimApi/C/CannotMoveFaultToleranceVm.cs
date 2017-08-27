namespace EnvironmentAssessment.Common.VimApi
{
	public class CannotMoveFaultToleranceVm : VimFault
	{
		protected string _moveType;
		protected string _vmName;
		public string MoveType
		{
			get
			{
				return this._moveType;
			}
			set
			{
				this._moveType = value;
			}
		}
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
	}
}
