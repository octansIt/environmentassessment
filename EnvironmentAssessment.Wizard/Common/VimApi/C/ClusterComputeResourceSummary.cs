namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterComputeResourceSummary : ComputeResourceSummary
	{
		protected int _currentFailoverLevel;
		protected ClusterDasAdmissionControlInfo _admissionControlInfo;
		protected int _numVmotions;
		protected int? _targetBalance;
		protected int? _currentBalance;
		protected ClusterUsageSummary _usageSummary;
		protected string _currentEVCModeKey;
		protected ClusterDasData _dasData;
		public int CurrentFailoverLevel
		{
			get
			{
				return this._currentFailoverLevel;
			}
			set
			{
				this._currentFailoverLevel = value;
			}
		}
		public ClusterDasAdmissionControlInfo AdmissionControlInfo
		{
			get
			{
				return this._admissionControlInfo;
			}
			set
			{
				this._admissionControlInfo = value;
			}
		}
		public int NumVmotions
		{
			get
			{
				return this._numVmotions;
			}
			set
			{
				this._numVmotions = value;
			}
		}
		public int? TargetBalance
		{
			get
			{
				return this._targetBalance;
			}
			set
			{
				this._targetBalance = value;
			}
		}
		public int? CurrentBalance
		{
			get
			{
				return this._currentBalance;
			}
			set
			{
				this._currentBalance = value;
			}
		}
		public ClusterUsageSummary UsageSummary
		{
			get
			{
				return this._usageSummary;
			}
			set
			{
				this._usageSummary = value;
			}
		}
		public string CurrentEVCModeKey
		{
			get
			{
				return this._currentEVCModeKey;
			}
			set
			{
				this._currentEVCModeKey = value;
			}
		}
		public ClusterDasData DasData
		{
			get
			{
				return this._dasData;
			}
			set
			{
				this._dasData = value;
			}
		}
	}
}
