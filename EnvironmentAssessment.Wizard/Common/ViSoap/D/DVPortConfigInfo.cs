namespace EnvironmentAssessment.Common.VISoap
{
    public class DVPortConfigInfo : DynamicData
	{
		protected string _name;
		protected ManagedObjectReference[] _scope;
		protected string _description;
		protected DVPortSetting _setting;
		protected string _configVersion;
		protected DVPortConfigInfo_LinkedView _linkedView;
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
		public ManagedObjectReference[] Scope
		{
			get
			{
				return this._scope;
			}
			set
			{
				this._scope = value;
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
		public DVPortSetting Setting
		{
			get
			{
				return this._setting;
			}
			set
			{
				this._setting = value;
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
		public DVPortConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
