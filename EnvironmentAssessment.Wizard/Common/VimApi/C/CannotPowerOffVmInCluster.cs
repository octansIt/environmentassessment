namespace EnvironmentAssessment.Common.VimApi
{
	public class CannotPowerOffVmInCluster : InvalidState
	{
		protected string _operation;
		protected ManagedObjectReference _vm;
		protected string _vmName;
		protected CannotPowerOffVmInCluster_LinkedView _linkedView;
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
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
		public string VmName
		{
			get
			{
				return this._vmName;
			}
			set
			{
				this._vmName = value;
			}
		}
		public CannotPowerOffVmInCluster_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
