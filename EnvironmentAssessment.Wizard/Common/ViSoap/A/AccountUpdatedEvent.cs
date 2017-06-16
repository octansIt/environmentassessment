namespace EnvironmentAssessment.Common.VISoap
{
    public class AccountUpdatedEvent : HostEvent
	{
		protected HostAccountSpec _spec;
		protected bool _group;
		public HostAccountSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
		public bool Group
		{
			get
			{
				return this._group;
			}
			set
			{
				this._group = value;
			}
		}
	}
}
