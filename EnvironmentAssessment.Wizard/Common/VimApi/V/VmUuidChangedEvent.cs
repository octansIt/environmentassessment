namespace EnvironmentAssessment.Common.VimApi
{
	public class VmUuidChangedEvent : VmEvent
	{
		protected string _oldUuid;
		protected string _newUuid;
		public string OldUuid
		{
			get
			{
				return this._oldUuid;
			}
			set
			{
				this._oldUuid = value;
			}
		}
		public string NewUuid
		{
			get
			{
				return this._newUuid;
			}
			set
			{
				this._newUuid = value;
			}
		}
	}
}
