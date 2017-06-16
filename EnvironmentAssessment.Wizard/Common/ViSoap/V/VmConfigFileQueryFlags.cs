namespace EnvironmentAssessment.Common.VISoap
{
    public class VmConfigFileQueryFlags : DynamicData
	{
		protected bool _configVersion;
		public bool ConfigVersion
		{
			get
			{
				return this._configVersion;
			}
			set
			{
				this._configVersion = value;
			}
		}
	}
}
