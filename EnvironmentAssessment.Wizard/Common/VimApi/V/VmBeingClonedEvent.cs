namespace EnvironmentAssessment.Common.VimApi
{
	public class VmBeingClonedEvent : VmCloneEvent
	{
		protected FolderEventArgument _destFolder;
		protected string _destName;
		protected HostEventArgument _destHost;
		public FolderEventArgument DestFolder
		{
			get
			{
				return this._destFolder;
			}
			set
			{
				this._destFolder = value;
			}
		}
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
