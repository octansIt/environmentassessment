namespace EnvironmentAssessment.Common.VimApi
{
	public class ExtensionHealthInfo : DynamicData
	{
		protected string _url;
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
