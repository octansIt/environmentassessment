namespace EnvironmentAssessment.Common.VimApi
{
	public class VmWwnChangedEvent : VmEvent
	{
		protected long[] _oldNodeWwns;
		protected long[] _oldPortWwns;
		protected long[] _newNodeWwns;
		protected long[] _newPortWwns;
		public long[] OldNodeWwns
		{
			get
			{
				return this._oldNodeWwns;
			}
			set
			{
				this._oldNodeWwns = value;
			}
		}
		public long[] OldPortWwns
		{
			get
			{
				return this._oldPortWwns;
			}
			set
			{
				this._oldPortWwns = value;
			}
		}
		public long[] NewNodeWwns
		{
			get
			{
				return this._newNodeWwns;
			}
			set
			{
				this._newNodeWwns = value;
			}
		}
		public long[] NewPortWwns
		{
			get
			{
				return this._newPortWwns;
			}
			set
			{
				this._newPortWwns = value;
			}
		}
	}
}
