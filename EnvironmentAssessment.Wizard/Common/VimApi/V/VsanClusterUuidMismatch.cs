namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanClusterUuidMismatch : CannotMoveVsanEnabledHost
	{
		protected string _hostClusterUuid;
		protected string _destinationClusterUuid;
		public string HostClusterUuid
		{
			get
			{
				return this._hostClusterUuid;
			}
			set
			{
				this._hostClusterUuid = value;
			}
		}
		public string DestinationClusterUuid
		{
			get
			{
				return this._destinationClusterUuid;
			}
			set
			{
				this._destinationClusterUuid = value;
			}
		}
	}
}
