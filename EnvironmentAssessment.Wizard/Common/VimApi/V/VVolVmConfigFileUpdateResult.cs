namespace EnvironmentAssessment.Common.VimApi
{
	public class VVolVmConfigFileUpdateResult : DynamicData
	{
		protected KeyValue[] _succeededVmConfigFile;
		protected VVolVmConfigFileUpdateResultFailedVmConfigFileInfo[] _failedVmConfigFile;
		public KeyValue[] SucceededVmConfigFile
		{
			get
			{
				return this._succeededVmConfigFile;
			}
			set
			{
				this._succeededVmConfigFile = value;
			}
		}
		public VVolVmConfigFileUpdateResultFailedVmConfigFileInfo[] FailedVmConfigFile
		{
			get
			{
				return this._failedVmConfigFile;
			}
			set
			{
				this._failedVmConfigFile = value;
			}
		}
	}
}
