namespace EnvironmentAssessment.Common.VISoap
{
    public class MigrationEvent : VmEvent
	{
		protected LocalizedMethodFault _fault;
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
