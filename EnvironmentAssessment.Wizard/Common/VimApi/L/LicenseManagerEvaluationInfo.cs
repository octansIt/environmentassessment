namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseManagerEvaluationInfo : DynamicData
	{
		protected KeyAnyValue[] _properties;
		public KeyAnyValue[] Properties
		{
			get
			{
				return this._properties;
			}
			set
			{
				this._properties = value;
			}
		}
	}
}
