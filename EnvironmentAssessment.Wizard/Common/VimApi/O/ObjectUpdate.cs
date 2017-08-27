namespace EnvironmentAssessment.Common.VimApi
{
	public class ObjectUpdate : DynamicData
	{
		protected ObjectUpdateKind _kind;
		protected ManagedObjectReference _obj;
		protected PropertyChange[] _changeSet;
		protected MissingProperty[] _missingSet;
		public ObjectUpdateKind Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}
		public ManagedObjectReference Obj
		{
			get
			{
				return this._obj;
			}
			set
			{
				this._obj = value;
			}
		}
		public PropertyChange[] ChangeSet
		{
			get
			{
				return this._changeSet;
			}
			set
			{
				this._changeSet = value;
			}
		}
		public MissingProperty[] MissingSet
		{
			get
			{
				return this._missingSet;
			}
			set
			{
				this._missingSet = value;
			}
		}
	}
}
