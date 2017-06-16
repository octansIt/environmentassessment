namespace EnvironmentAssessment.Common.VISoap
{
    public class ManagedByInfo : DynamicData
	{
		protected string _extensionKey;
		protected string _type;
		public string ExtensionKey
		{
			get
			{
				return this._extensionKey;
			}
			set
			{
				this._extensionKey = value;
			}
		}
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
	}
}
