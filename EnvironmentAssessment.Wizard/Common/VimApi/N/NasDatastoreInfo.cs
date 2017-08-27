namespace EnvironmentAssessment.Common.VimApi
{
	public class NasDatastoreInfo : DatastoreInfo
	{
		protected HostNasVolume _nas;
		public HostNasVolume Nas
		{
			get
			{
				return this._nas;
			}
			set
			{
				this._nas = value;
			}
		}
	}
}
