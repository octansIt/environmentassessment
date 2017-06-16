namespace EnvironmentAssessment.Common.VISoap
{
    public class VmFailedToPowerOnEvent : VmEvent
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
