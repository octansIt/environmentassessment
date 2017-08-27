namespace EnvironmentAssessment.Common.VimApi
{
	public class PatchNotApplicable : VimFault
	{
		protected string _patchID;
		public string PatchID
		{
			get
			{
				return this._patchID;
			}
			set
			{
				this._patchID = value;
			}
		}
	}
}
