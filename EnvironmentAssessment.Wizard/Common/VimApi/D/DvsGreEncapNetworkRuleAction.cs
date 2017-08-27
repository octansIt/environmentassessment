namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsGreEncapNetworkRuleAction : DvsNetworkRuleAction
	{
		protected SingleIp _encapsulationIp;
		public SingleIp EncapsulationIp
		{
			get
			{
				return this._encapsulationIp;
			}
			set
			{
				this._encapsulationIp = value;
			}
		}
	}
}
