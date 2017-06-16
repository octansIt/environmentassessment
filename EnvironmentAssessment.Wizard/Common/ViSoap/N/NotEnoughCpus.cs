namespace EnvironmentAssessment.Common.VISoap
{
    public class NotEnoughCpus : VirtualHardwareCompatibilityIssue
	{
		protected int _numCpuDest;
		protected int _numCpuVm;
		public int NumCpuDest
		{
			get
			{
				return this._numCpuDest;
			}
			set
			{
				this._numCpuDest = value;
			}
		}
		public int NumCpuVm
		{
			get
			{
				return this._numCpuVm;
			}
			set
			{
				this._numCpuVm = value;
			}
		}
	}
}
