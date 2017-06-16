namespace EnvironmentAssessment.Common.VISoap
{
    public class VAppConfigSpec : VmConfigSpec
	{
		protected VAppEntityConfigInfo[] _entityConfig;
		protected string _annotation;
		protected string _instanceUuid;
		protected ManagedByInfo _managedBy;
		public VAppEntityConfigInfo[] EntityConfig
		{
			get
			{
				return this._entityConfig;
			}
			set
			{
				this._entityConfig = value;
			}
		}
		public string Annotation
		{
			get
			{
				return this._annotation;
			}
			set
			{
				this._annotation = value;
			}
		}
		public string InstanceUuid
		{
			get
			{
				return this._instanceUuid;
			}
			set
			{
				this._instanceUuid = value;
			}
		}
		public ManagedByInfo ManagedBy
		{
			get
			{
				return this._managedBy;
			}
			set
			{
				this._managedBy = value;
			}
		}
	}
}
