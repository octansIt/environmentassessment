namespace EnvironmentAssessment.Common.VimApi
{
	public class ExtManagedEntityInfo : DynamicData
	{
		protected string _type;
		protected string _smallIconUrl;
		protected string _iconUrl;
		protected string _description;
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
		public string SmallIconUrl
		{
			get
			{
				return this._smallIconUrl;
			}
			set
			{
				this._smallIconUrl = value;
			}
		}
		public string IconUrl
		{
			get
			{
				return this._iconUrl;
			}
			set
			{
				this._iconUrl = value;
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
