namespace EnvironmentAssessment.Common.VimApi
{
	public class DestinationVsanDisabled : CannotMoveVsanEnabledHost
	{
		protected string _destinationCluster;
		public string DestinationCluster
		{
			get
			{
				return this._destinationCluster;
			}
			set
			{
				this._destinationCluster = value;
			}
		}
	}
}
