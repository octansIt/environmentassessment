namespace EnvironmentAssessment.Common.VISoap
{
    public class DatacenterMismatchArgument : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected ManagedObjectReference _inputDatacenter;
		protected DatacenterMismatchArgument_LinkedView _linkedView;
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public ManagedObjectReference InputDatacenter
		{
			get
			{
				return this._inputDatacenter;
			}
			set
			{
				this._inputDatacenter = value;
			}
		}
		public DatacenterMismatchArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
