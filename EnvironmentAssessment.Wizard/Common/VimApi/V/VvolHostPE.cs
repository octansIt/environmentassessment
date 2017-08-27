namespace EnvironmentAssessment.Common.VimApi
{
	public class VVolHostPE : DynamicData
	{
		protected ManagedObjectReference _key;
		protected HostProtocolEndpoint[] _protocolEndpoint;
		protected VVolHostPE_LinkedView _linkedView;
		public ManagedObjectReference Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public HostProtocolEndpoint[] ProtocolEndpoint
		{
			get
			{
				return this._protocolEndpoint;
			}
			set
			{
				this._protocolEndpoint = value;
			}
		}
		public VVolHostPE_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
