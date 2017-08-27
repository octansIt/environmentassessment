namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfNetworkInfo : DynamicData
	{
		protected string _name;
		protected string _description;
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
		public string Description
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
