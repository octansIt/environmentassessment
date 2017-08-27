namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationSysprep : CustomizationIdentitySettings
	{
		protected CustomizationGuiUnattended _guiUnattended;
		protected CustomizationUserData _userData;
		protected CustomizationGuiRunOnce _guiRunOnce;
		protected CustomizationIdentification _identification;
		protected CustomizationLicenseFilePrintData _licenseFilePrintData;
		public CustomizationGuiUnattended GuiUnattended
		{
			get
			{
				return this._guiUnattended;
			}
			set
			{
				this._guiUnattended = value;
			}
		}
		public CustomizationUserData UserData
		{
			get
			{
				return this._userData;
			}
			set
			{
				this._userData = value;
			}
		}
		public CustomizationGuiRunOnce GuiRunOnce
		{
			get
			{
				return this._guiRunOnce;
			}
			set
			{
				this._guiRunOnce = value;
			}
		}
		public CustomizationIdentification Identification
		{
			get
			{
				return this._identification;
			}
			set
			{
				this._identification = value;
			}
		}
		public CustomizationLicenseFilePrintData LicenseFilePrintData
		{
			get
			{
				return this._licenseFilePrintData;
			}
			set
			{
				this._licenseFilePrintData = value;
			}
		}
	}
}
