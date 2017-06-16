namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterVmComponentProtectionSettings : DynamicData
	{
		protected string _vmStorageProtectionForAPD;
		protected bool? _enableAPDTimeoutForHosts;
		protected int? _vmTerminateDelayForAPDSec;
		protected string _vmReactionOnAPDCleared;
		protected string _vmStorageProtectionForPDL;
		public string VmStorageProtectionForAPD
		{
			get
			{
				return this._vmStorageProtectionForAPD;
			}
			set
			{
				this._vmStorageProtectionForAPD = value;
			}
		}
		public bool? EnableAPDTimeoutForHosts
		{
			get
			{
				return this._enableAPDTimeoutForHosts;
			}
			set
			{
				this._enableAPDTimeoutForHosts = value;
			}
		}
		public int? VmTerminateDelayForAPDSec
		{
			get
			{
				return this._vmTerminateDelayForAPDSec;
			}
			set
			{
				this._vmTerminateDelayForAPDSec = value;
			}
		}
		public string VmReactionOnAPDCleared
		{
			get
			{
				return this._vmReactionOnAPDCleared;
			}
			set
			{
				this._vmReactionOnAPDCleared = value;
			}
		}
		public string VmStorageProtectionForPDL
		{
			get
			{
				return this._vmStorageProtectionForPDL;
			}
			set
			{
				this._vmStorageProtectionForPDL = value;
			}
		}
	}
}
