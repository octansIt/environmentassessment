namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidDatastoreState : InvalidState
	{
		protected string _datastoreName;
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
	}
}
