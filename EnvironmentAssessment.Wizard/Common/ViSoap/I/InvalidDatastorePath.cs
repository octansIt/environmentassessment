namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidDatastorePath : InvalidDatastore
	{
		protected string _datastorePath;
		public string DatastorePath
		{
			get
			{
				return this._datastorePath;
			}
			set
			{
				this._datastorePath = value;
			}
		}
		public new InvalidDatastorePath_LinkedView LinkedView
		{
			get
			{
				return (InvalidDatastorePath_LinkedView)this._linkedView;
			}
		}
	}
}
