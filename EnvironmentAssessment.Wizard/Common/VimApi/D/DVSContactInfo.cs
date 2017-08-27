namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSContactInfo : DynamicData
	{
		protected string _name;
		protected string _contact;
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
		public string Contact
		{
			get
			{
				return this._contact;
			}
			set
			{
				this._contact = value;
			}
		}
	}
}
