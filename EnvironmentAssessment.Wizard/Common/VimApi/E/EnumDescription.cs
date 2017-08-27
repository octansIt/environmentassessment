namespace EnvironmentAssessment.Common.VimApi
{
	public class EnumDescription : DynamicData
	{
		protected string _key;
		protected ElementDescription[] _tags;
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
		public ElementDescription[] Tags
		{
			get
			{
				return this._tags;
			}
			set
			{
				this._tags = value;
			}
		}
	}
}
