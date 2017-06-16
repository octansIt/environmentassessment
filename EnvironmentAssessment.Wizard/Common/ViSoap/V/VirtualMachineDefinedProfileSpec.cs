namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineDefinedProfileSpec : VirtualMachineProfileSpec
	{
		protected string _profileId;
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
