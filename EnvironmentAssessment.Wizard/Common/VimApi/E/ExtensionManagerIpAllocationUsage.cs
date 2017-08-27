namespace EnvironmentAssessment.Common.VimApi
{
	public class ExtensionManagerIpAllocationUsage : DynamicData
	{
		protected string _extensionKey;
		protected int _numAddresses;
		public string ExtensionKey
		{
			get
			{
				return this._extensionKey;
			}
			set
			{
				this._extensionKey = value;
			}
		}
		public int NumAddresses
		{
			get
			{
				return this._numAddresses;
			}
			set
			{
				this._numAddresses = value;
			}
		}
	}
}
