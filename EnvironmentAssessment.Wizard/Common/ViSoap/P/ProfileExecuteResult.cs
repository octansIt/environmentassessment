namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileExecuteResult : DynamicData
	{
		protected string _status;
		protected HostConfigSpec _configSpec;
		protected string[] _inapplicablePath;
		protected ProfileDeferredPolicyOptionParameter[] _requireInput;
		protected ProfileExecuteError[] _error;
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public HostConfigSpec ConfigSpec
		{
			get
			{
				return this._configSpec;
			}
			set
			{
				this._configSpec = value;
			}
		}
		public string[] InapplicablePath
		{
			get
			{
				return this._inapplicablePath;
			}
			set
			{
				this._inapplicablePath = value;
			}
		}
		public ProfileDeferredPolicyOptionParameter[] RequireInput
		{
			get
			{
				return this._requireInput;
			}
			set
			{
				this._requireInput = value;
			}
		}
		public ProfileExecuteError[] Error
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
	}
}
