namespace EnvironmentAssessment.Common.VISoap
{
    public class UnexpectedFault : RuntimeFault
	{
		protected string _faultName;
		protected LocalizedMethodFault _fault;
		public string FaultName
		{
			get
			{
				return this._faultName;
			}
			set
			{
				this._faultName = value;
			}
		}
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
