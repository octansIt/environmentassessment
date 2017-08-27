namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchManagerHostDvsFilterSpec : DynamicData
	{
		protected bool _inclusive;
		public bool Inclusive
		{
			get
			{
				return this._inclusive;
			}
			set
			{
				this._inclusive = value;
			}
		}
	}
}
