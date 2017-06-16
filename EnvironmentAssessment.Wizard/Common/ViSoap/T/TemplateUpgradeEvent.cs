namespace EnvironmentAssessment.Common.VISoap
{
    public class TemplateUpgradeEvent : Event
	{
		protected string _legacyTemplate;
		public string LegacyTemplate
		{
			get
			{
				return this._legacyTemplate;
			}
			set
			{
				this._legacyTemplate = value;
			}
		}
	}
}
