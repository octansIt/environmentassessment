namespace EnvironmentAssessment.Common.VimApi
{
	public class VmConfigFileQueryFilter : DynamicData
	{
		protected int[] _matchConfigVersion;
		protected bool? _encrypted;
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
		public bool? Encrypted
		{
			get
			{
				return this._encrypted;
			}
			set
			{
				this._encrypted = value;
			}
		}
	}
}
