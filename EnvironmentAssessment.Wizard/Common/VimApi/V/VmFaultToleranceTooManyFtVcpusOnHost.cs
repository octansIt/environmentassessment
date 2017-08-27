namespace EnvironmentAssessment.Common.VimApi
{
	public class VmFaultToleranceTooManyFtVcpusOnHost : InsufficientResourcesFault
	{
		protected string _hostName;
		protected int _maxNumFtVcpus;
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
		public int MaxNumFtVcpus
		{
			get
			{
				return this._maxNumFtVcpus;
			}
			set
			{
				this._maxNumFtVcpus = value;
			}
		}
	}
}
