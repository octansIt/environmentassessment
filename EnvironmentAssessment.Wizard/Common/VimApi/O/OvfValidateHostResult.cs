namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfValidateHostResult : DynamicData
	{
		protected long? _downloadSize;
		protected long? _flatDeploymentSize;
		protected long? _sparseDeploymentSize;
		protected LocalizedMethodFault[] _error;
		protected LocalizedMethodFault[] _warning;
		protected string[] _supportedDiskProvisioning;
		public long? DownloadSize
		{
			get
			{
				return this._downloadSize;
			}
			set
			{
				this._downloadSize = value;
			}
		}
		public long? FlatDeploymentSize
		{
			get
			{
				return this._flatDeploymentSize;
			}
			set
			{
				this._flatDeploymentSize = value;
			}
		}
		public long? SparseDeploymentSize
		{
			get
			{
				return this._sparseDeploymentSize;
			}
			set
			{
				this._sparseDeploymentSize = value;
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
		public string[] SupportedDiskProvisioning
		{
			get
			{
				return this._supportedDiskProvisioning;
			}
			set
			{
				this._supportedDiskProvisioning = value;
			}
		}
	}
}
