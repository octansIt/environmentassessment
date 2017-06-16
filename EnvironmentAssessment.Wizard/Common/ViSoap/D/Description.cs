namespace EnvironmentAssessment.Common.VISoap
{
    public class Description : DynamicData
	{
		protected string _label;
		protected string _summary;
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
		public string Summary
		{
			get
			{
				return this._summary;
			}
			set
			{
				this._summary = value;
			}
		}
	}
}
