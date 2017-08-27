namespace EnvironmentAssessment.Common.VimApi
{
	public class Relation : DynamicData
	{
		protected string _constraint;
		protected string _name;
		protected string _version;
		public string Constraint
		{
			get
			{
				return this._constraint;
			}
			set
			{
				this._constraint = value;
			}
		}
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
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
	}
}
