namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDrsMigration_LinkedView
	{
		protected VirtualMachine _vm;
		protected HostSystem _source;
		protected HostSystem _destination;
		public VirtualMachine Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public HostSystem Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public HostSystem Destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				this._destination = value;
			}
		}
	}
}
