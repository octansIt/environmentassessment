namespace EnvironmentAssessment.Common.VimApi
{
	public class VnicPortArgument : DynamicData
	{
		protected string _vnic;
		protected DistributedVirtualSwitchPortConnection _port;
		public string Vnic
		{
			get
			{
				return this._vnic;
			}
			set
			{
				this._vnic = value;
			}
		}
		public DistributedVirtualSwitchPortConnection Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
	}
}
