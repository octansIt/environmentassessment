namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSRollbackCapability : DynamicData
	{
		protected bool _rollbackSupported;
		public bool RollbackSupported
		{
			get
			{
				return this._rollbackSupported;
			}
			set
			{
				this._rollbackSupported = value;
			}
		}
	}
}
