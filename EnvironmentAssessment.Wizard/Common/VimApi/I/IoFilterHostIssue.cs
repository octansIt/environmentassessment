namespace EnvironmentAssessment.Common.VimApi
{
	public class IoFilterHostIssue : DynamicData
	{
		protected ManagedObjectReference _host;
		protected LocalizedMethodFault[] _issue;
		protected IoFilterHostIssue_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public LocalizedMethodFault[] Issue
		{
			get
			{
				return this._issue;
			}
			set
			{
				this._issue = value;
			}
		}
		public IoFilterHostIssue_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
