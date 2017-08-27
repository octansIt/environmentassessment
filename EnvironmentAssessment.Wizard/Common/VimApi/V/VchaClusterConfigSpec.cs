namespace EnvironmentAssessment.Common.VimApi
{
	public class VchaClusterConfigSpec : DynamicData
	{
		protected string _passiveIp;
		protected string _witnessIp;
		public string PassiveIp
		{
			get
			{
				return this._passiveIp;
			}
			set
			{
				this._passiveIp = value;
			}
		}
		public string WitnessIp
		{
			get
			{
				return this._witnessIp;
			}
			set
			{
				this._witnessIp = value;
			}
		}
	}
}
