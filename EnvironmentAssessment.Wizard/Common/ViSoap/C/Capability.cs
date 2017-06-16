namespace EnvironmentAssessment.Common.VISoap
{
    public class Capability : DynamicData
	{
		protected bool _provisioningSupported;
		protected bool _multiHostSupported;
		protected bool _userShellAccessSupported;
		protected EVCMode[] _supportedEVCMode;
		protected bool? _networkBackupAndRestoreSupported;
		public bool ProvisioningSupported
		{
			get
			{
				return this._provisioningSupported;
			}
			set
			{
				this._provisioningSupported = value;
			}
		}
		public bool MultiHostSupported
		{
			get
			{
				return this._multiHostSupported;
			}
			set
			{
				this._multiHostSupported = value;
			}
		}
		public bool UserShellAccessSupported
		{
			get
			{
				return this._userShellAccessSupported;
			}
			set
			{
				this._userShellAccessSupported = value;
			}
		}
		public EVCMode[] SupportedEVCMode
		{
			get
			{
				return this._supportedEVCMode;
			}
			set
			{
				this._supportedEVCMode = value;
			}
		}
		public bool? NetworkBackupAndRestoreSupported
		{
			get
			{
				return this._networkBackupAndRestoreSupported;
			}
			set
			{
				this._networkBackupAndRestoreSupported = value;
			}
		}
	}
}
