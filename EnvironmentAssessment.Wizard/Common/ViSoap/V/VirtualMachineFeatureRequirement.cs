namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineFeatureRequirement : DynamicData
	{
		protected string _key;
		protected string _featureName;
		protected string _value;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string FeatureName
		{
			get
			{
				return this._featureName;
			}
			set
			{
				this._featureName = value;
			}
		}
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
	}
}
