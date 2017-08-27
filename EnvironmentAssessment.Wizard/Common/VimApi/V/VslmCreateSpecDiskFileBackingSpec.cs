namespace EnvironmentAssessment.Common.VimApi
{
	public class VslmCreateSpecDiskFileBackingSpec : VslmCreateSpecBackingSpec
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
		public new VslmCreateSpecDiskFileBackingSpec_LinkedView LinkedView
		{
			get
			{
				return (VslmCreateSpecDiskFileBackingSpec_LinkedView)this._linkedView;
			}
		}
	}
}
