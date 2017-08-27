namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineDefinedProfileSpec : VirtualMachineProfileSpec
	{
		protected string _profileId;
		protected ReplicationSpec _replicationSpec;
		protected VirtualMachineProfileRawData _profileData;
		public string ProfileId
		{
			get
			{
				return this._profileId;
			}
			set
			{
				this._profileId = value;
			}
		}
		public ReplicationSpec ReplicationSpec
		{
			get
			{
				return this._replicationSpec;
			}
			set
			{
				this._replicationSpec = value;
			}
		}
		public VirtualMachineProfileRawData ProfileData
		{
			get
			{
				return this._profileData;
			}
			set
			{
				this._profileData = value;
			}
		}
	}
}
