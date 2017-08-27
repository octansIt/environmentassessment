namespace EnvironmentAssessment.Common.VimApi
{
	public class UnsupportedVimApiVersion : VimFault
	{
		protected string _version;
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
	}
}
