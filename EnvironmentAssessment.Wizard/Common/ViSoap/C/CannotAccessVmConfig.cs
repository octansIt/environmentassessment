namespace EnvironmentAssessment.Common.VISoap
{
    public class CannotAccessVmConfig : CannotAccessVmComponent
	{
		protected LocalizedMethodFault _reason;
		public LocalizedMethodFault Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}
