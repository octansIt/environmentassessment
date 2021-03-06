namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfPropertyExport : OvfExport
	{
		protected string _type;
		protected string _value;
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
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
