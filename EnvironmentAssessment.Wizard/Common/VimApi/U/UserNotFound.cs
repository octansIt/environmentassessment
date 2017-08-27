namespace EnvironmentAssessment.Common.VimApi
{
	public class UserNotFound : VimFault
	{
		protected string _principal;
		protected bool _unresolved;
		public string Principal
		{
			get
			{
				return this._principal;
			}
			set
			{
				this._principal = value;
			}
		}
		public bool Unresolved
		{
			get
			{
				return this._unresolved;
			}
			set
			{
				this._unresolved = value;
			}
		}
	}
}
