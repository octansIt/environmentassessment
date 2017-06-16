namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDeviceFileBackingInfo_LinkedView
	{
		protected Datastore _datastore;
		public Datastore Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
	}
}
