namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchHostMemberPnicBacking : DistributedVirtualSwitchHostMemberBacking
	{
		protected DistributedVirtualSwitchHostMemberPnicSpec[] _pnicSpec;
		public DistributedVirtualSwitchHostMemberPnicSpec[] PnicSpec
		{
			get
			{
				return this._pnicSpec;
			}
			set
			{
				this._pnicSpec = value;
			}
		}
	}
}
