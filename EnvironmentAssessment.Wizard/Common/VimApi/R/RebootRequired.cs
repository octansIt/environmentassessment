namespace EnvironmentAssessment.Common.VimApi
{
	public class RebootRequired : VimFault
	{
		protected string _patch;
		public string Patch
		{
			get
			{
				return this._patch;
			}
			set
			{
				this._patch = value;
			}
		}
	}
}
