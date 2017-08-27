namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDatastoreSystemVvolDatastoreSpec : DynamicData
	{
		protected string _name;
		protected string _scId;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string ScId
		{
			get
			{
				return this._scId;
			}
			set
			{
				this._scId = value;
			}
		}
	}
}
