namespace EnvironmentAssessment.Common.VimApi
{
	public class ManagedObjectNotFound : RuntimeFault
	{
		protected ManagedObjectReference _obj;
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
	}
}
