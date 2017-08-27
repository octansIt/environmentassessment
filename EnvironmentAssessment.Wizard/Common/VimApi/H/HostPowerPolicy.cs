namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPowerPolicy : DynamicData
	{
		protected int _key;
		protected string _name;
		protected string _shortName;
		protected string _description;
		public int Key
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
		public string ShortName
		{
			get
			{
				return this._shortName;
			}
			set
			{
				this._shortName = value;
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
