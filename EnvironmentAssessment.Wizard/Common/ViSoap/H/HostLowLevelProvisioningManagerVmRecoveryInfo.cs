namespace EnvironmentAssessment.Common.VISoap
{
    public class HostLowLevelProvisioningManagerVmRecoveryInfo : DynamicData
	{
		protected string _version;
		protected string _biosUUID;
		protected string _instanceUUID;
		protected FaultToleranceConfigInfo _ftInfo;
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
		public string BiosUUID
		{
			get
			{
				return this._biosUUID;
			}
			set
			{
				this._biosUUID = value;
			}
		}
		public string InstanceUUID
		{
			get
			{
				return this._instanceUUID;
			}
			set
			{
				this._instanceUUID = value;
			}
		}
		public FaultToleranceConfigInfo FtInfo
		{
			get
			{
				return this._ftInfo;
			}
			set
			{
				this._ftInfo = value;
			}
		}
	}
}
