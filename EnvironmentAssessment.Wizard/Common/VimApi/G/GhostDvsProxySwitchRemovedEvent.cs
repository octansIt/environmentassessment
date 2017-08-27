namespace EnvironmentAssessment.Common.VimApi
{
	public class GhostDvsProxySwitchRemovedEvent : HostEvent
	{
		protected string[] _switchUuid;
		public string[] SwitchUuid
		{
			get
			{
				return this._switchUuid;
			}
			set
			{
				this._switchUuid = value;
			}
		}
	}
}
