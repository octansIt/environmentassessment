namespace EnvironmentAssessment.Common.VISoap
{
    public class NumVirtualCpusNotSupported : VirtualHardwareCompatibilityIssue
	{
		protected int _maxSupportedVcpusDest;
		protected int _numCpuVm;
		public int MaxSupportedVcpusDest
		{
			get
			{
				return this._maxSupportedVcpusDest;
			}
			set
			{
				this._maxSupportedVcpusDest = value;
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
