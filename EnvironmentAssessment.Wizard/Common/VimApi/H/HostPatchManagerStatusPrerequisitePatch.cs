namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPatchManagerStatusPrerequisitePatch : DynamicData
	{
		protected string _id;
		protected string[] _installState;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string[] InstallState
		{
			get
			{
				return this._installState;
			}
			set
			{
				this._installState = value;
			}
		}
	}
}
