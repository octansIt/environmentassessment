namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileDeferredPolicyOptionParameter : DynamicData
	{
		protected ProfilePropertyPath _inputPath;
		protected KeyAnyValue[] _parameter;
		public ProfilePropertyPath InputPath
		{
			get
			{
				return this._inputPath;
			}
			set
			{
				this._inputPath = value;
			}
		}
		public KeyAnyValue[] Parameter
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
