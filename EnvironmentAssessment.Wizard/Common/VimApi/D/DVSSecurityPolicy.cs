namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSSecurityPolicy : InheritablePolicy
	{
		protected BoolPolicy _allowPromiscuous;
		protected BoolPolicy _macChanges;
		protected BoolPolicy _forgedTransmits;
		public BoolPolicy AllowPromiscuous
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
		public BoolPolicy MacChanges
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
		public BoolPolicy ForgedTransmits
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
