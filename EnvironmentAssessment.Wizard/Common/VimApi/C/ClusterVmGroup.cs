namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterVmGroup : ClusterGroupInfo
	{
		protected ManagedObjectReference[] _vm;
		protected ClusterVmGroup_LinkedView _linkedView;
		public ManagedObjectReference[] Vm
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
		public ClusterVmGroup_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
