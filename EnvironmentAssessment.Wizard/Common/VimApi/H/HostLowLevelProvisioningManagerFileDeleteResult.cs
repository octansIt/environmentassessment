namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLowLevelProvisioningManagerFileDeleteResult : DynamicData
	{
		protected string _fileName;
		protected LocalizedMethodFault _fault;
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				this._fileName = value;
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
