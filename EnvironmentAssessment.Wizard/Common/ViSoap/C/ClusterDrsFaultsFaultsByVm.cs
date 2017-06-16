namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDrsFaultsFaultsByVm : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected LocalizedMethodFault[] _fault;
		protected ClusterDrsFaultsFaultsByVm_LinkedView _linkedView;
		public ManagedObjectReference Vm
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
		public LocalizedMethodFault[] Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
		public ClusterDrsFaultsFaultsByVm_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
