namespace EnvironmentAssessment.Common.VISoap
{
    public class DatacenterMismatch : MigrationFault
	{
		protected DatacenterMismatchArgument[] _invalidArgument;
		protected ManagedObjectReference _expectedDatacenter;
		protected DatacenterMismatch_LinkedView _linkedView;
		public DatacenterMismatchArgument[] InvalidArgument
		{
			get
			{
				return this._invalidArgument;
			}
			set
			{
				this._invalidArgument = value;
			}
		}
		public ManagedObjectReference ExpectedDatacenter
		{
			get
			{
				return this._expectedDatacenter;
			}
			set
			{
				this._expectedDatacenter = value;
			}
		}
		public DatacenterMismatch_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
