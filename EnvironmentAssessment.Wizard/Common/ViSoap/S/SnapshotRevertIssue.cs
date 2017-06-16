namespace EnvironmentAssessment.Common.VISoap
{
    public class SnapshotRevertIssue : MigrationFault
	{
		protected string _snapshotName;
		protected Event[] _event;
		protected bool _errors;
		public string SnapshotName
		{
			get
			{
				return this._snapshotName;
			}
			set
			{
				this._snapshotName = value;
			}
		}
		public Event[] Event
		{
			get
			{
				return this._event;
			}
			set
			{
				this._event = value;
			}
		}
		public bool Errors
		{
			get
			{
				return this._errors;
			}
			set
			{
				this._errors = value;
			}
		}
	}
}
