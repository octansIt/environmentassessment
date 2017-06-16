namespace EnvironmentAssessment.Common.VISoap
{
    public class PosixUserSearchResult : UserSearchResult
	{
		protected int _id;
		protected bool? _shellAccess;
		public int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public bool? ShellAccess
		{
			get
			{
				return this._shellAccess;
			}
			set
			{
				this._shellAccess = value;
			}
		}
	}
}
