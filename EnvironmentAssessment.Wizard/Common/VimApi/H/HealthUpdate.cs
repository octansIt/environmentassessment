namespace EnvironmentAssessment.Common.VimApi
{
	public class HealthUpdate : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected string _healthUpdateInfoId;
		protected string _id;
		protected ManagedEntityStatus _status;
		protected string _remediation;
		protected HealthUpdate_LinkedView _linkedView;
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
		public string HealthUpdateInfoId
		{
			get
			{
				return this._healthUpdateInfoId;
			}
			set
			{
				this._healthUpdateInfoId = value;
			}
		}
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public ManagedEntityStatus Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public string Remediation
		{
			get
			{
				return this._remediation;
			}
			set
			{
				this._remediation = value;
			}
		}
		public HealthUpdate_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
