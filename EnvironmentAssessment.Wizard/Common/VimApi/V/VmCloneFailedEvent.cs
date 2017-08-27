namespace EnvironmentAssessment.Common.VimApi
{
	public class VmCloneFailedEvent : VmCloneEvent
	{
		protected FolderEventArgument _destFolder;
		protected string _destName;
		protected HostEventArgument _destHost;
		protected LocalizedMethodFault _reason;
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
		public LocalizedMethodFault Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}
