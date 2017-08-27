namespace EnvironmentAssessment.Common.VimApi
{
	public class ComplianceFailure : DynamicData
	{
		protected string _failureType;
		protected LocalizableMessage _message;
		protected string _expressionName;
		protected ComplianceFailureComplianceFailureValues[] _failureValues;
		public string FailureType
		{
			get
			{
				return this._failureType;
			}
			set
			{
				this._failureType = value;
			}
		}
		public LocalizableMessage Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}
		public string ExpressionName
		{
			get
			{
				return this._expressionName;
			}
			set
			{
				this._expressionName = value;
			}
		}
		public ComplianceFailureComplianceFailureValues[] FailureValues
		{
			get
			{
				return this._failureValues;
			}
			set
			{
				this._failureValues = value;
			}
		}
	}
}
