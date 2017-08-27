namespace EnvironmentAssessment.Common.VimApi
{
	public class HostUnresolvedVmfsResolutionResult : DynamicData
	{
		protected HostUnresolvedVmfsResolutionSpec _spec;
		protected HostVmfsVolume _vmfs;
		protected LocalizedMethodFault _fault;
		public HostUnresolvedVmfsResolutionSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
		public HostVmfsVolume Vmfs
		{
			get
			{
				return this._vmfs;
			}
			set
			{
				this._vmfs = value;
			}
		}
		public LocalizedMethodFault Fault
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
	}
}
