namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileExpressionMetadata : DynamicData
	{
		protected ExtendedElementDescription _expressionId;
		protected ProfileParameterMetadata[] _parameter;
		public ExtendedElementDescription ExpressionId
		{
			get
			{
				return this._expressionId;
			}
			set
			{
				this._expressionId = value;
			}
		}
		public ProfileParameterMetadata[] Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				this._parameter = value;
			}
		}
	}
}
