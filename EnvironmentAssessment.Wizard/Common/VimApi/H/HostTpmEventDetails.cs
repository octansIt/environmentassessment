namespace EnvironmentAssessment.Common.VimApi
{
	public class HostTpmEventDetails : DynamicData
	{
		protected sbyte[] _dataHash;
		public sbyte[] DataHash
		{
			get
			{
				return this._dataHash;
			}
			set
			{
				this._dataHash = value;
			}
		}
	}
}
