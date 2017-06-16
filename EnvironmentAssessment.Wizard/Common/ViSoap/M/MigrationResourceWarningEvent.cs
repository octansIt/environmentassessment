namespace EnvironmentAssessment.Common.VISoap
{
    public class MigrationResourceWarningEvent : MigrationEvent
	{
		protected ResourcePoolEventArgument _dstPool;
		protected HostEventArgument _dstHost;
		public ResourcePoolEventArgument DstPool
		{
			get
			{
				return this._dstPool;
			}
			set
			{
				this._dstPool = value;
			}
		}
		public HostEventArgument DstHost
		{
			get
			{
				return this._dstHost;
			}
			set
			{
				this._dstHost = value;
			}
		}
	}
}
