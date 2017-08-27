namespace EnvironmentAssessment.Common.VimApi
{
	public class VslmCreateSpecRawDiskMappingBackingSpec : VslmCreateSpecBackingSpec
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
		public new VslmCreateSpecRawDiskMappingBackingSpec_LinkedView LinkedView
		{
			get
			{
				return (VslmCreateSpecRawDiskMappingBackingSpec_LinkedView)this._linkedView;
			}
		}
	}
}
