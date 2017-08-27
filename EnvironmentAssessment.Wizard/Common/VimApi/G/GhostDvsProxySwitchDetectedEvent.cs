namespace EnvironmentAssessment.Common.VimApi
{
	public class GhostDvsProxySwitchDetectedEvent : HostEvent
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
