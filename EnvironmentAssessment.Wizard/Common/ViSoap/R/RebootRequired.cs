namespace EnvironmentAssessment.Common.VISoap
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
