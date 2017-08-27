namespace EnvironmentAssessment.Common.VimApi
{
	public class VmUuidAssignedEvent : VmEvent
	{
		protected string _uuid;
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
	}
}
