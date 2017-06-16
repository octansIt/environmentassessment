namespace EnvironmentAssessment.Common.VISoap
{
    public class HostResignatureRescanResult : DynamicData
	{
		protected HostVmfsRescanResult[] _rescan;
		protected ManagedObjectReference _result;
		protected HostResignatureRescanResult_LinkedView _linkedView;
		public HostVmfsRescanResult[] Rescan
		{
			get
			{
				return this._rescan;
			}
			set
			{
				this._rescan = value;
			}
		}
		public ManagedObjectReference Result
		{
			get
			{
				return this._result;
			}
			set
			{
				this._result = value;
			}
		}
		public HostResignatureRescanResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
