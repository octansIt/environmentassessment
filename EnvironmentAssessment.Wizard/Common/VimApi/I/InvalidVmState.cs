namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidVmState : InvalidState
	{
		protected ManagedObjectReference _vm;
		protected InvalidVmState_LinkedView _linkedView;
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
		public InvalidVmState_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
