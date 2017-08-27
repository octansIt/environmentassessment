namespace EnvironmentAssessment.Common.VimApi
{
	public class PowerOnFtSecondaryTimedout : Timedout
	{
		protected ManagedObjectReference _vm;
		protected string _vmName;
		protected int _timeout;
		protected PowerOnFtSecondaryTimedout_LinkedView _linkedView;
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
		public int Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				this._timeout = value;
			}
		}
		public PowerOnFtSecondaryTimedout_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
