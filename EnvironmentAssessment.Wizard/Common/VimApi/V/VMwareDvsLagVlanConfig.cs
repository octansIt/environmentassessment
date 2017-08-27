namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDvsLagVlanConfig : DynamicData
	{
		protected NumericRange[] _vlanId;
		public NumericRange[] VlanId
		{
			get
			{
				return this._vlanId;
			}
			set
			{
				this._vlanId = value;
			}
		}
	}
}
