namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsConfigInfo : DynamicData
	{
		protected StorageDrsPodConfigInfo _podConfig;
		protected StorageDrsVmConfigInfo[] _vmConfig;
		public StorageDrsPodConfigInfo PodConfig
		{
			get
			{
				return this._podConfig;
			}
			set
			{
				this._podConfig = value;
			}
		}
		public StorageDrsVmConfigInfo[] VmConfig
		{
			get
			{
				return this._vmConfig;
			}
			set
			{
				this._vmConfig = value;
			}
		}
	}
}
