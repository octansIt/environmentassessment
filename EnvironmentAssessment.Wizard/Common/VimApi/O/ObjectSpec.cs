namespace EnvironmentAssessment.Common.VimApi
{
	public class ObjectSpec : DynamicData
	{
		protected ManagedObjectReference _obj;
		protected bool? _skip;
		protected SelectionSpec[] _selectSet;
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
		public bool? Skip
		{
			get
			{
				return this._skip;
			}
			set
			{
				this._skip = value;
			}
		}
		public SelectionSpec[] SelectSet
		{
			get
			{
				return this._selectSet;
			}
			set
			{
				this._selectSet = value;
			}
		}
	}
}
