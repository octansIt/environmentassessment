namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskConfigSpec : VirtualDeviceConfigSpec
	{
		protected bool? _migrateCache;
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
