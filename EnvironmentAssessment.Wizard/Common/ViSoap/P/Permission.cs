namespace EnvironmentAssessment.Common.VISoap
{
    public class Permission : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected string _principal;
		protected bool _group;
		protected int _roleId;
		protected bool _propagate;
		protected Permission_LinkedView _linkedView;
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
		public string Principal
		{
			get
			{
				return this._principal;
			}
			set
			{
				this._principal = value;
			}
		}
		public bool Group
		{
			get
			{
				return this._group;
			}
			set
			{
				this._group = value;
			}
		}
		public int RoleId
		{
			get
			{
				return this._roleId;
			}
			set
			{
				this._roleId = value;
			}
		}
		public bool Propagate
		{
			get
			{
				return this._propagate;
			}
			set
			{
				this._propagate = value;
			}
		}
		public Permission_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
