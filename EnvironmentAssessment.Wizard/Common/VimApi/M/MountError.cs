namespace EnvironmentAssessment.Common.VimApi
{
    public class MountError : CustomizationFault
	{
		protected ManagedObjectReference _vm;
		protected int _diskIndex;
		protected MountError_LinkedView _linkedView;
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
		public int DiskIndex
		{
			get
			{
				return this._diskIndex;
			}
			set
			{
				this._diskIndex = value;
			}
		}
		public MountError_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
