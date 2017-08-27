namespace EnvironmentAssessment.Common.VimApi
{
	public class VVolVmConfigFileUpdateResultFailedVmConfigFileInfo : DynamicData
	{
		protected string _targetConfigVVolId;
		protected LocalizedMethodFault _fault;
		public string TargetConfigVVolId
		{
			get
			{
				return this._targetConfigVVolId;
			}
			set
			{
				this._targetConfigVVolId = value;
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
