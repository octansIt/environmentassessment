namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _dvs;
		protected DvsEventArgument_LinkedView _linkedView;
		public ManagedObjectReference Dvs
		{
			get
			{
				return this._dvs;
			}
			set
			{
				this._dvs = value;
			}
		}
		public DvsEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
