namespace EnvironmentAssessment.Common.VimApi
{
	public class VmWwnConflict : InvalidVmConfig
	{
		protected ManagedObjectReference _vm;
		protected ManagedObjectReference _host;
		protected string _name;
		protected long? _wwn;
		protected VmWwnConflict_LinkedView _linkedView;
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
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public long? Wwn
		{
			get
			{
				return this._wwn;
			}
			set
			{
				this._wwn = value;
			}
		}
		public VmWwnConflict_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
