namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsImportEvent : DvsEvent
	{
		protected string _importType;
		public string ImportType
		{
			get
			{
				return this._importType;
			}
			set
			{
				this._importType = value;
			}
		}
	}
}
