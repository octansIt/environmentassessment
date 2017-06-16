namespace EnvironmentAssessment.Common.VISoap
{
    public class UnSupportedDatastoreForVFlash : UnsupportedDatastore
	{
		protected string _datastoreName;
		protected string _type;
		public string DatastoreName
		{
			get
			{
				return this._datastoreName;
			}
			set
			{
				this._datastoreName = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public new UnSupportedDatastoreForVFlash_LinkedView LinkedView
		{
			get
			{
				return (UnSupportedDatastoreForVFlash_LinkedView)this._linkedView;
			}
		}
	}
}
