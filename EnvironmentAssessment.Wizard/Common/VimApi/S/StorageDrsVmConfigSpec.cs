namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsVmConfigSpec : ArrayUpdateSpec
	{
		protected StorageDrsVmConfigInfo _info;
		public StorageDrsVmConfigInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
