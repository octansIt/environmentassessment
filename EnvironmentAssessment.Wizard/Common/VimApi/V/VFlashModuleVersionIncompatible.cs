namespace EnvironmentAssessment.Common.VimApi
{
	public class VFlashModuleVersionIncompatible : VimFault
	{
		protected string _moduleName;
		protected string _vmRequestModuleVersion;
		protected string _hostMinSupportedVerson;
		protected string _hostModuleVersion;
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
		public string VmRequestModuleVersion
		{
			get
			{
				return this._vmRequestModuleVersion;
			}
			set
			{
				this._vmRequestModuleVersion = value;
			}
		}
		public string HostMinSupportedVerson
		{
			get
			{
				return this._hostMinSupportedVerson;
			}
			set
			{
				this._hostMinSupportedVerson = value;
			}
		}
		public string HostModuleVersion
		{
			get
			{
				return this._hostModuleVersion;
			}
			set
			{
				this._hostModuleVersion = value;
			}
		}
	}
}
