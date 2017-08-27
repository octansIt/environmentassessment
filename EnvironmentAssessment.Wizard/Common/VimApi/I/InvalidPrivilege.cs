namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidPrivilege : VimFault
	{
		protected string _privilege;
		public string Privilege
		{
			get
			{
				return this._privilege;
			}
			set
			{
				this._privilege = value;
			}
		}
	}
}
