namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegValueNameSpec : DynamicData
	{
		protected GuestRegKeyNameSpec _keyName;
		protected string _name;
		public GuestRegKeyNameSpec KeyName
		{
			get
			{
				return this._keyName;
			}
			set
			{
				this._keyName = value;
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
