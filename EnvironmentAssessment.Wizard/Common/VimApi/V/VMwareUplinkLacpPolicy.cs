namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareUplinkLacpPolicy : InheritablePolicy
	{
		protected BoolPolicy _enable;
		protected StringPolicy _mode;
		public BoolPolicy Enable
		{
			get
			{
				return this._enable;
			}
			set
			{
				this._enable = value;
			}
		}
		public StringPolicy Mode
		{
			get
			{
				return this._mode;
			}
			set
			{
				this._mode = value;
			}
		}
	}
}
