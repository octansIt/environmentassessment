namespace EnvironmentAssessment.Common.VimApi
{
	public class ChangesInfoEventArgument : DynamicData
	{
		protected string _modified;
		protected string _added;
		protected string _deleted;
		public string Modified
		{
			get
			{
				return this._modified;
			}
			set
			{
				this._modified = value;
			}
		}
		public string Added
		{
			get
			{
				return this._added;
			}
			set
			{
				this._added = value;
			}
		}
		public string Deleted
		{
			get
			{
				return this._deleted;
			}
			set
			{
				this._deleted = value;
			}
		}
	}
}
