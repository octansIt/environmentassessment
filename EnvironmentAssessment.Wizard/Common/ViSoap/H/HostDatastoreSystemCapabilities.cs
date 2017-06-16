namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDatastoreSystemCapabilities : DynamicData
	{
		protected bool _nfsMountCreationRequired;
		protected bool _nfsMountCreationSupported;
		protected bool _localDatastoreSupported;
		protected bool _vmfsExtentExpansionSupported;
		public bool NfsMountCreationRequired
		{
			get
			{
				return this._nfsMountCreationRequired;
			}
			set
			{
				this._nfsMountCreationRequired = value;
			}
		}
		public bool NfsMountCreationSupported
		{
			get
			{
				return this._nfsMountCreationSupported;
			}
			set
			{
				this._nfsMountCreationSupported = value;
			}
		}
		public bool LocalDatastoreSupported
		{
			get
			{
				return this._localDatastoreSupported;
			}
			set
			{
				this._localDatastoreSupported = value;
			}
		}
		public bool VmfsExtentExpansionSupported
		{
			get
			{
				return this._vmfsExtentExpansionSupported;
			}
			set
			{
				this._vmfsExtentExpansionSupported = value;
			}
		}
	}
}
