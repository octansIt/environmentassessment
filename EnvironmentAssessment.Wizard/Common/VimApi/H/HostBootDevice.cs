namespace EnvironmentAssessment.Common.VimApi
{
	public class HostBootDevice : DynamicData
	{
		protected string _key;
		protected string _description;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
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
