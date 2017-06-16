namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterFailoverResourcesAdmissionControlInfo : ClusterDasAdmissionControlInfo
	{
		protected int _currentCpuFailoverResourcesPercent;
		protected int _currentMemoryFailoverResourcesPercent;
		public int CurrentCpuFailoverResourcesPercent
		{
			get
			{
				return this._currentCpuFailoverResourcesPercent;
			}
			set
			{
				this._currentCpuFailoverResourcesPercent = value;
			}
		}
		public int CurrentMemoryFailoverResourcesPercent
		{
			get
			{
				return this._currentMemoryFailoverResourcesPercent;
			}
			set
			{
				this._currentMemoryFailoverResourcesPercent = value;
			}
		}
	}
}
