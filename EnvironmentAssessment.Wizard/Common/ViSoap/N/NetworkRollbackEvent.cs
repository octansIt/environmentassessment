namespace EnvironmentAssessment.Common.VISoap
{
    public class NetworkRollbackEvent : Event
	{
		protected string _methodName;
		protected string _transactionId;
		public string MethodName
		{
			get
			{
				return this._methodName;
			}
			set
			{
				this._methodName = value;
			}
		}
		public string TransactionId
		{
			get
			{
				return this._transactionId;
			}
			set
			{
				this._transactionId = value;
			}
		}
	}
}
