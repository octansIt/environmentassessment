namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVmfsRescanResult : DynamicData
	{
		protected ManagedObjectReference _host;
		protected LocalizedMethodFault _fault;
		protected HostVmfsRescanResult_LinkedView _linkedView;
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
		public HostVmfsRescanResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
