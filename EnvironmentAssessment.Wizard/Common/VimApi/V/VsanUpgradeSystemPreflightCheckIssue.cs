namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemPreflightCheckIssue : DynamicData
	{
		protected string _msg;
		public string Msg
		{
			get
			{
				return this._msg;
			}
			set
			{
				this._msg = value;
			}
		}
	}
}
