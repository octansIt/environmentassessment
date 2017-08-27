namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineProfileRawData : DynamicData
	{
		protected string _extensionKey;
		protected string _objectData;
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
		public string ObjectData
		{
			get
			{
				return this._objectData;
			}
			set
			{
				this._objectData = value;
			}
		}
	}
}
