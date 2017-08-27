namespace EnvironmentAssessment.Common.VimApi
{
	public class RestrictedByAdministrator : RuntimeFault
	{
		protected string _details;
		public string Details
		{
			get
			{
				return this._details;
			}
			set
			{
				this._details = value;
			}
		}
	}
}
