namespace EnvironmentAssessment.Common.VimApi
{
	public class VvolDatastoreInfo : DatastoreInfo
	{
		protected HostVvolVolume _vvolDS;
		public HostVvolVolume VvolDS
		{
			get
			{
				return this._vvolDS;
			}
			set
			{
				this._vvolDS = value;
			}
		}
	}
}
