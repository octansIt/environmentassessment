namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFibreChannelOverEthernetHbaLinkInfo : DynamicData
	{
		protected string _vnportMac;
		protected string _fcfMac;
		protected int _vlanId;
		public string VnportMac
		{
			get
			{
				return this._vnportMac;
			}
			set
			{
				this._vnportMac = value;
			}
		}
		public string FcfMac
		{
			get
			{
				return this._fcfMac;
			}
			set
			{
				this._fcfMac = value;
			}
		}
		public int VlanId
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
