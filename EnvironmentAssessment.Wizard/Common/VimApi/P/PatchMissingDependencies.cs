namespace EnvironmentAssessment.Common.VimApi
{
	public class PatchMissingDependencies : PatchNotApplicable
	{
		protected string[] _prerequisitePatch;
		protected string[] _prerequisiteLib;
		public string[] PrerequisitePatch
		{
			get
			{
				return this._prerequisitePatch;
			}
			set
			{
				this._prerequisitePatch = value;
			}
		}
		public string[] PrerequisiteLib
		{
			get
			{
				return this._prerequisiteLib;
			}
			set
			{
				this._prerequisiteLib = value;
			}
		}
	}
}
