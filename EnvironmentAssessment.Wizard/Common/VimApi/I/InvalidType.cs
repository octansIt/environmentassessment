namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidType : InvalidRequest
	{
		protected string _argument;
		public string Argument
		{
			get
			{
				return this._argument;
			}
			set
			{
				this._argument = value;
			}
		}
	}
}
