namespace EnvironmentAssessment.Common.VimApi
{
	public class SessionManagerVmomiServiceRequestSpec : SessionManagerServiceRequestSpec
	{
		protected string _method;
		public string Method
		{
			get
			{
				return this._method;
			}
			set
			{
				this._method = value;
			}
		}
	}
}
