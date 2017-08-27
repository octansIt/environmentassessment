namespace EnvironmentAssessment.Common.VimApi
{
	public class VMotionLinkDown : VMotionInterfaceIssue
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
		public new VMotionLinkDown_LinkedView LinkedView
		{
			get
			{
				return (VMotionLinkDown_LinkedView)this._linkedView;
			}
		}
	}
}
