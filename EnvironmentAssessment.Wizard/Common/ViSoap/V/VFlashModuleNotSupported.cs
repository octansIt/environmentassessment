namespace EnvironmentAssessment.Common.VISoap
{
    public class VFlashModuleNotSupported : VmConfigFault
	{
		protected string _vmName;
		protected string _moduleName;
		protected string _reason;
		protected string _hostName;
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
		public string ModuleName
		{
			get
			{
				return this._moduleName;
			}
			set
			{
				this._moduleName = value;
			}
		}
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public string HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
	}
}
