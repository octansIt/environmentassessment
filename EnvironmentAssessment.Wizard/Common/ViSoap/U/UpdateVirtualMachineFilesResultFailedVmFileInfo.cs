namespace EnvironmentAssessment.Common.VISoap
{
    public class UpdateVirtualMachineFilesResultFailedVmFileInfo : DynamicData
	{
		protected string _vmFile;
		protected LocalizedMethodFault _fault;
		public string VmFile
		{
			get
			{
				return this._vmFile;
			}
			set
			{
				this._vmFile = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
