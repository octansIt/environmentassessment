namespace EnvironmentAssessment.Common.VimApi
{
	public class MissingObject : DynamicData
	{
		protected ManagedObjectReference _obj;
		protected LocalizedMethodFault _fault;
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
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
