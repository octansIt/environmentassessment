namespace EnvironmentAssessment.Common.VISoap
{
    public class VmWwnAssignedEvent : VmEvent
	{
		protected long[] _nodeWwns;
		protected long[] _portWwns;
		public long[] NodeWwns
		{
			get
			{
				return this._nodeWwns;
			}
			set
			{
				this._nodeWwns = value;
			}
		}
		public long[] PortWwns
		{
			get
			{
				return this._portWwns;
			}
			set
			{
				this._portWwns = value;
			}
		}
	}
}
