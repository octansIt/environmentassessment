namespace EnvironmentAssessment.Common.VimApi
{
	public class EntityBackupConfig : DynamicData
	{
		protected string _entityType;
		protected byte[] _configBlob;
		protected string _key;
		protected string _name;
		protected ManagedObjectReference _container;
		protected string _configVersion;
		protected EntityBackupConfig_LinkedView _linkedView;
		public string EntityType
		{
			get
			{
				return this._entityType;
			}
			set
			{
				this._entityType = value;
			}
		}
		public byte[] ConfigBlob
		{
			get
			{
				return this._configBlob;
			}
			set
			{
				this._configBlob = value;
			}
		}
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
		public ManagedObjectReference Container
		{
			get
			{
				return this._container;
			}
			set
			{
				this._container = value;
			}
		}
		public string ConfigVersion
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
		public EntityBackupConfig_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
