namespace EnvironmentAssessment.Common.VimApi
{
	public class HostAccountSpec : DynamicData
	{
		protected string _id;
		protected string _password;
		protected string _description;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				this._password = value;
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
