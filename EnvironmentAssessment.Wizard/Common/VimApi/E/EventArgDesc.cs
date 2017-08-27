namespace EnvironmentAssessment.Common.VimApi
{
	public class EventArgDesc : DynamicData
	{
		protected string _name;
		protected string _type;
		protected ElementDescription _description;
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
		public ElementDescription Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
