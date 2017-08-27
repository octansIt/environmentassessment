namespace EnvironmentAssessment.Common.VimApi
{
	public class NumVirtualCpusIncompatible : VmConfigFault
	{
		protected string _reason;
		protected int _numCpu;
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public int NumCpu
		{
			get
			{
				return this._numCpu;
			}
			set
			{
				this._numCpu = value;
			}
		}
	}
}
