namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNumaInfo : DynamicData
	{
		protected string _type;
		protected int _numNodes;
		protected HostNumaNode[] _numaNode;
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public int NumNodes
		{
			get
			{
				return this._numNodes;
			}
			set
			{
				this._numNodes = value;
			}
		}
		public HostNumaNode[] NumaNode
		{
			get
			{
				return this._numaNode;
			}
			set
			{
				this._numaNode = value;
			}
		}
	}
}
