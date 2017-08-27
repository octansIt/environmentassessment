namespace EnvironmentAssessment.Common.VimApi
{
	public class AccountRemovedEvent : HostEvent
	{
		protected string _account;
		protected bool _group;
		public string Account
		{
			get
			{
				return this._account;
			}
			set
			{
				this._account = value;
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
