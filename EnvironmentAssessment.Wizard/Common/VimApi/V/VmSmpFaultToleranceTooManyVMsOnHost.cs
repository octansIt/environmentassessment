namespace EnvironmentAssessment.Common.VimApi
{
	public class VmSmpFaultToleranceTooManyVMsOnHost : InsufficientResourcesFault
	{
		protected string _hostName;
		protected int _maxNumSmpFtVms;
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
		public int MaxNumSmpFtVms
		{
			get
			{
				return this._maxNumSmpFtVms;
			}
			set
			{
				this._maxNumSmpFtVms = value;
			}
		}
	}
}
