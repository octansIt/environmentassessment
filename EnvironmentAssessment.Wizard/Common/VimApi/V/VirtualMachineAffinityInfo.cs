namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineAffinityInfo : DynamicData
	{
		protected int[] _affinitySet;
		public int[] AffinitySet
		{
			get
			{
				return this._affinitySet;
			}
			set
			{
				this._affinitySet = value;
			}
		}
	}
}
