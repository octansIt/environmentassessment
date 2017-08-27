namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostIpConfig : DynamicData
	{
		protected string _upstreamIpAddress;
		protected string _downstreamIpAddress;
		public string UpstreamIpAddress
		{
			get
			{
				return this._upstreamIpAddress;
			}
			set
			{
				this._upstreamIpAddress = value;
			}
		}
		public string DownstreamIpAddress
		{
			get
			{
				return this._downstreamIpAddress;
			}
			set
			{
				this._downstreamIpAddress = value;
			}
		}
	}
}
