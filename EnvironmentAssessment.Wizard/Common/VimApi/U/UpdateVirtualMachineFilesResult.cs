namespace EnvironmentAssessment.Common.VimApi
{
	public class UpdateVirtualMachineFilesResult : DynamicData
	{
		protected UpdateVirtualMachineFilesResultFailedVmFileInfo[] _failedVmFile;
		public UpdateVirtualMachineFilesResultFailedVmFileInfo[] FailedVmFile
		{
			get
			{
				return this._failedVmFile;
			}
			set
			{
				this._failedVmFile = value;
			}
		}
	}
}
