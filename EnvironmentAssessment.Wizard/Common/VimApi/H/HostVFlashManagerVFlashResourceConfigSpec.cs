namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVFlashManagerVFlashResourceConfigSpec : DynamicData
	{
		protected string _vffsUuid;
		public string VffsUuid
		{
			get
			{
				return this._vffsUuid;
			}
			set
			{
				this._vffsUuid = value;
			}
		}
	}
}
