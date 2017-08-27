namespace EnvironmentAssessment.Common.VimApi
{
	public class VmBeingClonedNoFolderEvent : VmCloneEvent
	{
		protected string _destName;
		protected HostEventArgument _destHost;
		public string DestName
		{
			get
			{
				return this._destName;
			}
			set
			{
				this._destName = value;
			}
		}
		public HostEventArgument DestHost
		{
			get
			{
				return this._destHost;
			}
			set
			{
				this._destHost = value;
			}
		}
	}
}
