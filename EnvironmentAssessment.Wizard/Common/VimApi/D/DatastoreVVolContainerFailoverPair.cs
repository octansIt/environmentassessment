namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastoreVVolContainerFailoverPair : DynamicData
	{
		protected string _srcContainer;
		protected string _tgtContainer;
		protected KeyValue[] _vvolMapping;
		public string SrcContainer
		{
			get
			{
				return this._srcContainer;
			}
			set
			{
				this._srcContainer = value;
			}
		}
		public string TgtContainer
		{
			get
			{
				return this._tgtContainer;
			}
			set
			{
				this._tgtContainer = value;
			}
		}
		public KeyValue[] VvolMapping
		{
			get
			{
				return this._vvolMapping;
			}
			set
			{
				this._vvolMapping = value;
			}
		}
	}
}
