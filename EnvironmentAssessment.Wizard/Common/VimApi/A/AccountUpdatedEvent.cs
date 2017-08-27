namespace EnvironmentAssessment.Common.VimApi
{
	public class AccountUpdatedEvent : HostEvent
	{
		protected HostAccountSpec _spec;
		protected bool _group;
		protected string _prevDescription;
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
		public string PrevDescription
		{
			get
			{
				return this._prevDescription;
			}
			set
			{
				this._prevDescription = value;
			}
		}
	}
}
