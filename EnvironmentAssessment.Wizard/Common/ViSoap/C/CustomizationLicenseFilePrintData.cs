namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationLicenseFilePrintData : DynamicData
	{
		protected CustomizationLicenseDataMode _autoMode;
		protected int? _autoUsers;
		public CustomizationLicenseDataMode AutoMode
		{
			get
			{
				return this._autoMode;
			}
			set
			{
				this._autoMode = value;
			}
		}
		public int? AutoUsers
		{
			get
			{
				return this._autoUsers;
			}
			set
			{
				this._autoUsers = value;
			}
		}
	}
}
