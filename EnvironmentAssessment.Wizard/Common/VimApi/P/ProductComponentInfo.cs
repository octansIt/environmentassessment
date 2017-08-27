namespace EnvironmentAssessment.Common.VimApi
{
	public class ProductComponentInfo : DynamicData
	{
		protected string _id;
		protected string _name;
		protected string _version;
		protected int _release;
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
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
		public int Release
		{
			get
			{
				return this._release;
			}
			set
			{
				this._release = value;
			}
		}
	}
}
