namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFirewallDefaultPolicy : DynamicData
	{
		protected bool? _incomingBlocked;
		protected bool? _outgoingBlocked;
		public bool? IncomingBlocked
		{
			get
			{
				return this._incomingBlocked;
			}
			set
			{
				this._incomingBlocked = value;
			}
		}
		public bool? OutgoingBlocked
		{
			get
			{
				return this._outgoingBlocked;
			}
			set
			{
				this._outgoingBlocked = value;
			}
		}
	}
}
