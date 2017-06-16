namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDeviceFileBackingInfo : VirtualDeviceBackingInfo
	{
		protected string _fileName;
		protected ManagedObjectReference _datastore;
		protected string _backingObjectId;
		protected VirtualDeviceFileBackingInfo_LinkedView _linkedView;
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				this._fileName = value;
			}
		}
		public ManagedObjectReference Datastore
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
		public string BackingObjectId
		{
			get
			{
				return this._backingObjectId;
			}
			set
			{
				this._backingObjectId = value;
			}
		}
		public VirtualDeviceFileBackingInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
