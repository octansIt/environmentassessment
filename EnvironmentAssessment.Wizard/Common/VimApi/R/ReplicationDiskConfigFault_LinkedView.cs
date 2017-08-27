namespace EnvironmentAssessment.Common.VimApi
{
	public class ReplicationDiskConfigFault_LinkedView
	{
		protected VirtualMachine _vmRef;
		public VirtualMachine VmRef
		{
			get
			{
				return this._vmRef;
			}
			set
			{
				this._vmRef = value;
			}
		}
	}
}
