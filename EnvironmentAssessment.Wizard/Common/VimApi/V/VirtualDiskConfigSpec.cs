namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskConfigSpec : VirtualDeviceConfigSpec
	{
		protected string _diskMoveType;
		protected bool? _migrateCache;
		public string DiskMoveType
		{
			get
			{
				return this._diskMoveType;
			}
			set
			{
				this._diskMoveType = value;
			}
		}
		public bool? MigrateCache
		{
			get
			{
				return this._migrateCache;
			}
			set
			{
				this._migrateCache = value;
			}
		}
	}
}
