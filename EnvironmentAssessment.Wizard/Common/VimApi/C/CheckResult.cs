namespace EnvironmentAssessment.Common.VimApi
{
	public class CheckResult : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected ManagedObjectReference _host;
		protected LocalizedMethodFault[] _warning;
		protected LocalizedMethodFault[] _error;
		protected CheckResult_LinkedView _linkedView;
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
		public LocalizedMethodFault[] Warning
		{
			get
			{
				return this._warning;
			}
			set
			{
				this._warning = value;
			}
		}
		public LocalizedMethodFault[] Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
		public CheckResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
