namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppIPAssignmentInfo : DynamicData
	{
		protected string[] _supportedAllocationScheme;
		protected string _ipAllocationPolicy;
		protected string[] _supportedIpProtocol;
		protected string _ipProtocol;
		public string[] SupportedAllocationScheme
		{
			get
			{
				return this._supportedAllocationScheme;
			}
			set
			{
				this._supportedAllocationScheme = value;
			}
		}
		public string IpAllocationPolicy
		{
			get
			{
				return this._ipAllocationPolicy;
			}
			set
			{
				this._ipAllocationPolicy = value;
			}
		}
		public string[] SupportedIpProtocol
		{
			get
			{
				return this._supportedIpProtocol;
			}
			set
			{
				this._supportedIpProtocol = value;
			}
		}
		public string IpProtocol
		{
			get
			{
				return this._ipProtocol;
			}
			set
			{
				this._ipProtocol = value;
			}
		}
	}
}
