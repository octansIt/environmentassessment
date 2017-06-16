namespace EnvironmentAssessment.Common.VISoap
{
    public class VmFaultToleranceTooManyVMsOnHost : InsufficientResourcesFault
	{
		protected string _hostName;
		protected int _maxNumFtVms;
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
		public int MaxNumFtVms
		{
			get
			{
				return this._maxNumFtVms;
			}
			set
			{
				this._maxNumFtVms = value;
			}
		}
	}
}
