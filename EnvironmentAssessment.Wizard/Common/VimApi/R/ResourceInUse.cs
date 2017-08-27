namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourceInUse : VimFault
	{
		protected string _type;
		protected string _name;
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
	}
}
