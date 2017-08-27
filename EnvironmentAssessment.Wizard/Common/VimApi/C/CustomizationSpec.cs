namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationSpec : DynamicData
	{
		protected CustomizationOptions _options;
		protected CustomizationIdentitySettings _identity;
		protected CustomizationGlobalIPSettings _globalIPSettings;
		protected CustomizationAdapterMapping[] _nicSettingMap;
		protected sbyte[] _encryptionKey;
		public CustomizationOptions Options
		{
			get
			{
				return this._options;
			}
			set
			{
				this._options = value;
			}
		}
		public CustomizationIdentitySettings Identity
		{
			get
			{
				return this._identity;
			}
			set
			{
				this._identity = value;
			}
		}
		public CustomizationGlobalIPSettings GlobalIPSettings
		{
			get
			{
				return this._globalIPSettings;
			}
			set
			{
				this._globalIPSettings = value;
			}
		}
		public CustomizationAdapterMapping[] NicSettingMap
		{
			get
			{
				return this._nicSettingMap;
			}
			set
			{
				this._nicSettingMap = value;
			}
		}
		public sbyte[] EncryptionKey
		{
			get
			{
				return this._encryptionKey;
			}
			set
			{
				this._encryptionKey = value;
			}
		}
	}
}
