namespace EnvironmentAssessment.Common.VimApi
{
	public class VmConfigFileInfo : FileInfo
	{
		protected int? _configVersion;
		protected VmConfigFileEncryptionInfo _encryption;
		public int? ConfigVersion
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
		public VmConfigFileEncryptionInfo Encryption
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
