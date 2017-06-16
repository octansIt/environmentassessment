namespace EnvironmentAssessment.Common.VISoap
{
    public class FaultToleranceSecondaryOpResult : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected bool _powerOnAttempted;
		protected ClusterPowerOnVmResult _powerOnResult;
		protected FaultToleranceSecondaryOpResult_LinkedView _linkedView;
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public bool PowerOnAttempted
		{
			get
			{
				return this._powerOnAttempted;
			}
			set
			{
				this._powerOnAttempted = value;
			}
		}
		public ClusterPowerOnVmResult PowerOnResult
		{
			get
			{
				return this._powerOnResult;
			}
			set
			{
				this._powerOnResult = value;
			}
		}
		public FaultToleranceSecondaryOpResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
