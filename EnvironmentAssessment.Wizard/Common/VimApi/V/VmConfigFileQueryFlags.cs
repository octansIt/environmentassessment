namespace EnvironmentAssessment.Common.VimApi
{
	public class VmConfigFileQueryFlags : DynamicData
	{
		protected bool _configVersion;
		protected bool? _encryption;
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
		public bool? Encryption
		{
			get
			{
				return this._encryption;
			}
			set
			{
				this._encryption = value;
			}
		}
	}
}
