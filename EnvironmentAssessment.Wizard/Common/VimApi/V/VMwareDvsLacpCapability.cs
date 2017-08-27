namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDvsLacpCapability : DynamicData
	{
		protected bool? _lacpSupported;
		protected bool? _multiLacpGroupSupported;
		public bool? LacpSupported
		{
			get
			{
				return this._lacpSupported;
			}
			set
			{
				this._lacpSupported = value;
			}
		}
		public bool? MultiLacpGroupSupported
		{
			get
			{
				return this._multiLacpGroupSupported;
			}
			set
			{
				this._multiLacpGroupSupported = value;
			}
		}
	}
}
