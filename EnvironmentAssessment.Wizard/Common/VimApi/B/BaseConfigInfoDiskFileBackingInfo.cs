namespace EnvironmentAssessment.Common.VimApi
{
	public class BaseConfigInfoDiskFileBackingInfo : BaseConfigInfoFileBackingInfo
	{
		protected string _provisioningType;
		public string ProvisioningType
		{
			get
			{
				return this._provisioningType;
			}
			set
			{
				this._provisioningType = value;
			}
		}
		public new BaseConfigInfoDiskFileBackingInfo_LinkedView LinkedView
		{
			get
			{
				return (BaseConfigInfoDiskFileBackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
