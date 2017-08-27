namespace EnvironmentAssessment.Common.VimApi
{
	public class HealthUpdateInfo : DynamicData
	{
		protected string _id;
		protected string _componentType;
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
		public string ComponentType
		{
			get
			{
				return this._componentType;
			}
			set
			{
				this._componentType = value;
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
