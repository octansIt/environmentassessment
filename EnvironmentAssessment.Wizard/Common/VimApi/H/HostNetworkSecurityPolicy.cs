namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNetworkSecurityPolicy : DynamicData
	{
		protected bool? _allowPromiscuous;
		protected bool? _macChanges;
		protected bool? _forgedTransmits;
		public bool? AllowPromiscuous
		{
			get
			{
				return this._allowPromiscuous;
			}
			set
			{
				this._allowPromiscuous = value;
			}
		}
		public bool? MacChanges
		{
			get
			{
				return this._macChanges;
			}
			set
			{
				this._macChanges = value;
			}
		}
		public bool? ForgedTransmits
		{
			get
			{
				return this._forgedTransmits;
			}
			set
			{
				this._forgedTransmits = value;
			}
		}
	}
}
