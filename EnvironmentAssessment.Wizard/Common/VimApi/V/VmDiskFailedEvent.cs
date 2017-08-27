namespace EnvironmentAssessment.Common.VimApi
{
	public class VmDiskFailedEvent : VmEvent
	{
		protected string _disk;
		protected LocalizedMethodFault _reason;
		public string Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
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
