namespace EnvironmentAssessment.Common.VISoap
{
    public class FaultToleranceSecondaryConfigInfo : FaultToleranceConfigInfo
	{
		protected ManagedObjectReference _primaryVM;
		protected FaultToleranceSecondaryConfigInfo_LinkedView _linkedView;
		public ManagedObjectReference PrimaryVM
		{
			get
			{
				return this._primaryVM;
			}
			set
			{
				this._primaryVM = value;
			}
		}
		public FaultToleranceSecondaryConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
