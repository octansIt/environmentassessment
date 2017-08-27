namespace EnvironmentAssessment.Common.VimApi
{
	public class PatchSuperseded : PatchNotApplicable
	{
		protected string[] _supersede;
		public string[] Supersede
		{
			get
			{
				return this._supersede;
			}
			set
			{
				this._supersede = value;
			}
		}
	}
}
