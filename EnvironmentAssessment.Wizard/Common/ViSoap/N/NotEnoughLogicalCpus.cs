namespace EnvironmentAssessment.Common.VISoap
{
    public class NotEnoughLogicalCpus : NotEnoughCpus
	{
		protected ManagedObjectReference _host;
		protected NotEnoughLogicalCpus_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public NotEnoughLogicalCpus_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
