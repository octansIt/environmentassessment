namespace EnvironmentAssessment.Common.VISoap
{
    public class LocalizedMethodFault : DynamicData
	{
		protected MethodFault _fault;
		protected string _localizedMessage;
		public MethodFault Fault
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
		public string LocalizedMessage
		{
			get
			{
				return this._localizedMessage;
			}
			set
			{
				this._localizedMessage = value;
			}
		}
	}
}
