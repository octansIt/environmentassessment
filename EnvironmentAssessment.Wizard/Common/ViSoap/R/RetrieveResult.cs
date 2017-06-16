namespace EnvironmentAssessment.Common.VISoap
{
    public class RetrieveResult : DynamicData
	{
		protected string _token;
		protected ObjectContent[] _objects;
		public string Token
		{
			get
			{
				return this._token;
			}
			set
			{
				this._token = value;
			}
		}
		public ObjectContent[] Objects
		{
			get
			{
				return this._objects;
			}
			set
			{
				this._objects = value;
			}
		}
	}
}
