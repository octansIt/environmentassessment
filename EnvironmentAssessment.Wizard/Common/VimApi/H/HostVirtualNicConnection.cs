namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualNicConnection : DynamicData
	{
		protected string _portgroup;
		protected DistributedVirtualSwitchPortConnection _dvPort;
		public string Portgroup
		{
			get
			{
				return this._portgroup;
			}
			set
			{
				this._portgroup = value;
			}
		}
		public DistributedVirtualSwitchPortConnection DvPort
		{
			get
			{
				return this._dvPort;
			}
			set
			{
				this._dvPort = value;
			}
		}
	}
}
