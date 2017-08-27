namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomFieldDef : DynamicData
	{
		protected int _key;
		protected string _name;
		protected string _type;
		protected string _managedObjectType;
		protected PrivilegePolicyDef _fieldDefPrivileges;
		protected PrivilegePolicyDef _fieldInstancePrivileges;
		public int Key
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
		public string ManagedObjectType
		{
			get
			{
				return this._managedObjectType;
			}
			set
			{
				this._managedObjectType = value;
			}
		}
		public PrivilegePolicyDef FieldDefPrivileges
		{
			get
			{
				return this._fieldDefPrivileges;
			}
			set
			{
				this._fieldDefPrivileges = value;
			}
		}
		public PrivilegePolicyDef FieldInstancePrivileges
		{
			get
			{
				return this._fieldInstancePrivileges;
			}
			set
			{
				this._fieldInstancePrivileges = value;
			}
		}
	}
}
