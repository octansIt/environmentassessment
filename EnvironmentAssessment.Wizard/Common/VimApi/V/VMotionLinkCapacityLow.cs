namespace EnvironmentAssessment.Common.VimApi
{
	public class VMotionLinkCapacityLow : VMotionInterfaceIssue
	{
		protected string _network;
		public string Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public new VMotionLinkCapacityLow_LinkedView LinkedView
		{
			get
			{
				return (VMotionLinkCapacityLow_LinkedView)this._linkedView;
			}
		}
	}
}
