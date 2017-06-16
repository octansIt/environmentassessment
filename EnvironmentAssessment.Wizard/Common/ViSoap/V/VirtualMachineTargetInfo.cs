namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineTargetInfo : DynamicData
	{
		protected string _name;
		protected string[] _configurationTag;
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
		public string[] ConfigurationTag
		{
			get
			{
				return this._configurationTag;
			}
			set
			{
				this._configurationTag = value;
			}
		}
	}
}
