namespace EnvironmentAssessment.Common.VISoap
{
    public class LicenseAssignmentManagerLicenseAssignment : DynamicData
	{
		protected string _entityId;
		protected string _scope;
		protected string _entityDisplayName;
		protected LicenseManagerLicenseInfo _assignedLicense;
		protected KeyAnyValue[] _properties;
		public string EntityId
		{
			get
			{
				return this._entityId;
			}
			set
			{
				this._entityId = value;
			}
		}
		public string Scope
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
		public string EntityDisplayName
		{
			get
			{
				return this._entityDisplayName;
			}
			set
			{
				this._entityDisplayName = value;
			}
		}
		public LicenseManagerLicenseInfo AssignedLicense
		{
			get
			{
				return this._assignedLicense;
			}
			set
			{
				this._assignedLicense = value;
			}
		}
		public KeyAnyValue[] Properties
		{
			get
			{
				return this._properties;
			}
			set
			{
				this._properties = value;
			}
		}
	}
}
