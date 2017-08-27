namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDateTimeSystemTimeZone : DynamicData
	{
		protected string _key;
		protected string _name;
		protected string _description;
		protected int _gmtOffset;
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
		public int GmtOffset
		{
			get
			{
				return this._gmtOffset;
			}
			set
			{
				this._gmtOffset = value;
			}
		}
	}
}
