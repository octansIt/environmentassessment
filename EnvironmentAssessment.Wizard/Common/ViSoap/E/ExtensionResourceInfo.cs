namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtensionResourceInfo : DynamicData
	{
		protected string _locale;
		protected string _module;
		protected KeyValue[] _data;
		public string Locale
		{
			get
			{
				return this._locale;
			}
			set
			{
				this._locale = value;
			}
		}
		public string Module
		{
			get
			{
				return this._module;
			}
			set
			{
				this._module = value;
			}
		}
		public KeyValue[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
	}
}
