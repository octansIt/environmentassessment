namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppCloneSpecNetworkMappingPair_LinkedView
	{
		protected Network _source;
		protected Network _destination;
		public Network Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public Network Destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				this._destination = value;
			}
		}
	}
}
