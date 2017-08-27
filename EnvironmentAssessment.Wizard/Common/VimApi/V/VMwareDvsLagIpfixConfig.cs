namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDvsLagIpfixConfig : DynamicData
	{
		protected bool? _ipfixEnabled;
		public bool? IpfixEnabled
		{
			get
			{
				return this._ipfixEnabled;
			}
			set
			{
				this._ipfixEnabled = value;
			}
		}
	}
}
