namespace EnvironmentAssessment.Common.VimApi
{
	public class DynamicProperty
	{
		protected string _name;
		protected object _val;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public object Val
		{
			get
			{
				return this._val;
			}
			set
			{
				this._val = value;
			}
		}
	}
}
