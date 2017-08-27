namespace EnvironmentAssessment.Common.VimApi
{
	public class VmAlreadyExistsInDatacenter : InvalidFolder
	{
		protected ManagedObjectReference _host;
		protected string _hostname;
		protected ManagedObjectReference[] _vm;
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
		public string Hostname
		{
			get
			{
				return this._hostname;
			}
			set
			{
				this._hostname = value;
			}
		}
		public ManagedObjectReference[] Vm
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
		public new VmAlreadyExistsInDatacenter_LinkedView LinkedView
		{
			get
			{
				return (VmAlreadyExistsInDatacenter_LinkedView)this._linkedView;
			}
		}
	}
}
