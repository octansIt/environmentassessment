namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterFixedSizeSlotPolicy : ClusterSlotPolicy
	{
		protected int _cpu;
		protected int _memory;
		public int Cpu
		{
			get
			{
				return this._cpu;
			}
			set
			{
				this._cpu = value;
			}
		}
		public int Memory
		{
			get
			{
				return this._memory;
			}
			set
			{
				this._memory = value;
			}
		}
	}
}
