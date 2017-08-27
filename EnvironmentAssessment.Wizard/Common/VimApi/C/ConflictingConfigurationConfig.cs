namespace EnvironmentAssessment.Common.VimApi
{
	public class ConflictingConfigurationConfig : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected string _propertyPath;
		protected ConflictingConfigurationConfig_LinkedView _linkedView;
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public string PropertyPath
		{
			get
			{
				return this._propertyPath;
			}
			set
			{
				this._propertyPath = value;
			}
		}
		public ConflictingConfigurationConfig_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
