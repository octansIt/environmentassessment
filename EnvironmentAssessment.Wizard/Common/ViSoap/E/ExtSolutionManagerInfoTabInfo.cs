namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtSolutionManagerInfoTabInfo : DynamicData
	{
		protected string _label;
		protected string _url;
		public string Label
		{
			get
			{
				return this._label;
			}
			set
			{
				this._label = value;
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
