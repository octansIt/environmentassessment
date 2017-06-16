namespace EnvironmentAssessment.Common.VISoap
{
    public class VmConfigFileQueryFilter : DynamicData
	{
		protected int[] _matchConfigVersion;
		public int[] MatchConfigVersion
		{
			get
			{
				return this._matchConfigVersion;
			}
			set
			{
				this._matchConfigVersion = value;
			}
		}
	}
}
