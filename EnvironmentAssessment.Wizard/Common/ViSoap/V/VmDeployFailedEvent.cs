namespace EnvironmentAssessment.Common.VISoap
{
    public class VmDeployFailedEvent : VmEvent
	{
		protected EntityEventArgument _destDatastore;
		protected LocalizedMethodFault _reason;
		public EntityEventArgument DestDatastore
		{
			get
			{
				return this._destDatastore;
			}
			set
			{
				this._destDatastore = value;
			}
		}
		public LocalizedMethodFault Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}
