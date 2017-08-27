namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultTolerancePrimaryConfigInfo : FaultToleranceConfigInfo
	{
		protected ManagedObjectReference[] _secondaries;
		protected FaultTolerancePrimaryConfigInfo_LinkedView _linkedView;
		public ManagedObjectReference[] Secondaries
		{
			get
			{
				return this._secondaries;
			}
			set
			{
				this._secondaries = value;
			}
		}
		public FaultTolerancePrimaryConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
