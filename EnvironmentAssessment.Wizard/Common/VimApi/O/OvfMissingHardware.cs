namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfMissingHardware : OvfImport
	{
		protected string _name;
		protected int _resourceType;
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
		public int ResourceType
		{
			get
			{
				return this._resourceType;
			}
			set
			{
				this._resourceType = value;
			}
		}
	}
}
