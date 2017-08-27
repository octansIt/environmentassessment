namespace EnvironmentAssessment.Common.VimApi
{
	public class VmInstanceUuidChangedEvent : VmEvent
	{
		protected string _oldInstanceUuid;
		protected string _newInstanceUuid;
		public string OldInstanceUuid
		{
			get
			{
				return this._oldInstanceUuid;
			}
			set
			{
				this._oldInstanceUuid = value;
			}
		}
		public string NewInstanceUuid
		{
			get
			{
				return this._newInstanceUuid;
			}
			set
			{
				this._newInstanceUuid = value;
			}
		}
	}
}
