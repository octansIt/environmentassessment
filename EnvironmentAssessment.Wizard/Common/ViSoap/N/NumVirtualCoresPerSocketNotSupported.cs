namespace EnvironmentAssessment.Common.VISoap
{
    public class NumVirtualCoresPerSocketNotSupported : VirtualHardwareCompatibilityIssue
	{
		protected int _maxSupportedCoresPerSocketDest;
		protected int _numCoresPerSocketVm;
		public int MaxSupportedCoresPerSocketDest
		{
			get
			{
				return this._maxSupportedCoresPerSocketDest;
			}
			set
			{
				this._maxSupportedCoresPerSocketDest = value;
			}
		}
		public int NumCoresPerSocketVm
		{
			get
			{
				return this._numCoresPerSocketVm;
			}
			set
			{
				this._numCoresPerSocketVm = value;
			}
		}
	}
}
