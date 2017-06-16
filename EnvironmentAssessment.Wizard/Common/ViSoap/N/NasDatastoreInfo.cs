namespace EnvironmentAssessment.Common.VISoap
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
