namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidEditionLicense : NotEnoughLicenses
	{
		protected string _feature;
		public string Feature
		{
			get
			{
				return this._feature;
			}
			set
			{
				this._feature = value;
			}
		}
	}
}
