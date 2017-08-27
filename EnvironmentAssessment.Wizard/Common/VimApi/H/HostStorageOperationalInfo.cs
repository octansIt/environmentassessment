namespace EnvironmentAssessment.Common.VimApi
{
	public class HostStorageOperationalInfo : DynamicData
	{
		protected string _property;
		protected string _value;
		public string Property
		{
			get
			{
				return this._property;
			}
			set
			{
				this._property = value;
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
