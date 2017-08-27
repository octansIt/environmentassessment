namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidIndexArgument : InvalidArgument
	{
		protected string _key;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
	}
}
