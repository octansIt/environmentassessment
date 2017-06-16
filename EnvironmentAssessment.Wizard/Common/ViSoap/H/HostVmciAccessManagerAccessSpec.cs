namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVmciAccessManagerAccessSpec : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected string[] _services;
		protected string _mode;
		protected HostVmciAccessManagerAccessSpec_LinkedView _linkedView;
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
		public string[] Services
		{
			get
			{
				return this._services;
			}
			set
			{
				this._services = value;
			}
		}
		public string Mode
		{
			get
			{
				return this._mode;
			}
			set
			{
				this._mode = value;
			}
		}
		public HostVmciAccessManagerAccessSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
