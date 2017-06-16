namespace EnvironmentAssessment.Common.VISoap
{
    public class ComplianceLocator : DynamicData
	{
		protected string _expressionName;
		protected ProfilePropertyPath _applyPath;
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
		public ProfilePropertyPath ApplyPath
		{
			get
			{
				return this._applyPath;
			}
			set
			{
				this._applyPath = value;
			}
		}
	}
}
