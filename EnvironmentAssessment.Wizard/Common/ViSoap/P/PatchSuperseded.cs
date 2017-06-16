namespace EnvironmentAssessment.Common.VISoap
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
