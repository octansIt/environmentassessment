namespace EnvironmentAssessment.Common.VimApi
{
	public class SharesInfo : DynamicData
	{
		protected int _shares;
		protected SharesLevel _level;
		public int Shares
		{
			get
			{
				return this._shares;
			}
			set
			{
				this._shares = value;
			}
		}
		public SharesLevel Level
		{
			get
			{
				return this._level;
			}
			set
			{
				this._level = value;
			}
		}
	}
}
