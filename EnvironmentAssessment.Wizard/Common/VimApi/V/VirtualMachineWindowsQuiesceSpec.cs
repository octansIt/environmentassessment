namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineWindowsQuiesceSpec : VirtualMachineGuestQuiesceSpec
	{
		protected int? _vssBackupType;
		protected bool? _vssBootableSystemState;
		protected bool? _vssPartialFileSupport;
		protected string _vssBackupContext;
		public int? VssBackupType
		{
			get
			{
				return this._vssBackupType;
			}
			set
			{
				this._vssBackupType = value;
			}
		}
		public bool? VssBootableSystemState
		{
			get
			{
				return this._vssBootableSystemState;
			}
			set
			{
				this._vssBootableSystemState = value;
			}
		}
		public bool? VssPartialFileSupport
		{
			get
			{
				return this._vssPartialFileSupport;
			}
			set
			{
				this._vssPartialFileSupport = value;
			}
		}
		public string VssBackupContext
		{
			get
			{
				return this._vssBackupContext;
			}
			set
			{
				this._vssBackupContext = value;
			}
		}
	}
}
