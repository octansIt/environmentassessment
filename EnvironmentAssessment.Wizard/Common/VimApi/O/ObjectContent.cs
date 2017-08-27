namespace EnvironmentAssessment.Common.VimApi
{
	public class ObjectContent : DynamicData
	{
		protected ManagedObjectReference _obj;
		protected DynamicProperty[] _propSet;
		protected MissingProperty[] _missingSet;
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
		public DynamicProperty[] PropSet
		{
			get
			{
				return this._propSet;
			}
			set
			{
				this._propSet = value;
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
