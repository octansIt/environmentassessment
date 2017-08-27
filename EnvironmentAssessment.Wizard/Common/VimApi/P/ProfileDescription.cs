namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileDescription : DynamicData
	{
		protected ProfileDescriptionSection[] _section;
		public ProfileDescriptionSection[] Section
		{
			get
			{
				return this._section;
			}
			set
			{
				this._section = value;
			}
		}
	}
}
