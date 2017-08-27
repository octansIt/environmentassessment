namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfConsumerUndeclaredSection : OvfConsumerCallbackFault
	{
		protected string _qualifiedSectionType;
		public string QualifiedSectionType
		{
			get
			{
				return this._qualifiedSectionType;
			}
			set
			{
				this._qualifiedSectionType = value;
			}
		}
	}
}
