namespace EnvironmentAssessment.Common.VimApi
{
	public class BaseConfigInfoRawDiskMappingBackingInfo : BaseConfigInfoFileBackingInfo
	{
		protected string _lunUuid;
		protected string _compatibilityMode;
		public string LunUuid
		{
			get
			{
				return this._lunUuid;
			}
			set
			{
				this._lunUuid = value;
			}
		}
		public string CompatibilityMode
		{
			get
			{
				return this._compatibilityMode;
			}
			set
			{
				this._compatibilityMode = value;
			}
		}
		public new BaseConfigInfoRawDiskMappingBackingInfo_LinkedView LinkedView
		{
			get
			{
				return (BaseConfigInfoRawDiskMappingBackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
