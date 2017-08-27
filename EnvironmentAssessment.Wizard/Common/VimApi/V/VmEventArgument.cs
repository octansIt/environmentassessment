namespace EnvironmentAssessment.Common.VimApi
{
	public class VmEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _vm;
		protected VmEventArgument_LinkedView _linkedView;
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public VmEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
