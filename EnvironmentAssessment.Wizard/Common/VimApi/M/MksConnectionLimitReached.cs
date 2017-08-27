namespace EnvironmentAssessment.Common.VimApi
{
	public class MksConnectionLimitReached : InvalidState
	{
		protected int _connectionLimit;
		public int ConnectionLimit
		{
			get
			{
				return this._connectionLimit;
			}
			set
			{
				this._connectionLimit = value;
			}
		}
	}
}
