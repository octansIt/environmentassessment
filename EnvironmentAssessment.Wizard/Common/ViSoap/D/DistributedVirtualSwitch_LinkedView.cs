namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitch_LinkedView : ManagedEntity_LinkedView
	{
		protected DistributedVirtualPortgroup[] _portgroup;
		public DistributedVirtualPortgroup[] Portgroup
		{
			get
			{
				return this._portgroup;
			}
		}
	}
}
