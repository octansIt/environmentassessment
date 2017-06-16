namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDiskId : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected int _diskId;
		protected VirtualDiskId_LinkedView _linkedView;
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
		public int DiskId
		{
			get
			{
				return this._diskId;
			}
			set
			{
				this._diskId = value;
			}
		}
		public VirtualDiskId_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
