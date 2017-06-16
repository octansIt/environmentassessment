namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationWinOptions : CustomizationOptions
	{
		protected bool _changeSID;
		protected bool _deleteAccounts;
		protected CustomizationSysprepRebootOption? _reboot;
		public bool ChangeSID
		{
			get
			{
				return this._changeSID;
			}
			set
			{
				this._changeSID = value;
			}
		}
		public bool DeleteAccounts
		{
			get
			{
				return this._deleteAccounts;
			}
			set
			{
				this._deleteAccounts = value;
			}
		}
		public CustomizationSysprepRebootOption? Reboot
		{
			get
			{
				return this._reboot;
			}
			set
			{
				this._reboot = value;
			}
		}
	}
}
