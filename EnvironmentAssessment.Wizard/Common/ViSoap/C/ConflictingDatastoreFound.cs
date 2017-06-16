namespace EnvironmentAssessment.Common.VISoap
{
    public class ConflictingDatastoreFound : RuntimeFault
	{
		protected string _name;
		protected string _url;
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
		public string Url
		{
			get
			{
				return this._url;
			}
			set
			{
				this._url = value;
			}
		}
	}
}
