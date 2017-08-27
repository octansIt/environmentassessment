namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsConfigSpec : DynamicData
	{
		protected StorageDrsPodConfigSpec _podConfigSpec;
		protected StorageDrsVmConfigSpec[] _vmConfigSpec;
		public StorageDrsPodConfigSpec PodConfigSpec
		{
			get
			{
				return this._podConfigSpec;
			}
			set
			{
				this._podConfigSpec = value;
			}
		}
		public StorageDrsVmConfigSpec[] VmConfigSpec
		{
			get
			{
				return this._vmConfigSpec;
			}
			set
			{
				this._vmConfigSpec = value;
			}
		}
	}
}
