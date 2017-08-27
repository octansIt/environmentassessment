namespace EnvironmentAssessment.Common.VimApi
{
	public class DatacenterMismatchArgument_LinkedView
	{
		protected ManagedEntity _entity;
		protected Datacenter _inputDatacenter;
		public ManagedEntity Entity
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
		public Datacenter InputDatacenter
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
	}
}
