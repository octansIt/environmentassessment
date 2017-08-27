namespace EnvironmentAssessment.Common.VimApi
{
	public class VmMacAssignedEvent : VmEvent
	{
		protected string _adapter;
		protected string _mac;
		public string Adapter
		{
			get
			{
				return this._adapter;
			}
			set
			{
				this._adapter = value;
			}
		}
		public string Mac
		{
			get
			{
				return this._mac;
			}
			set
			{
				this._mac = value;
			}
		}
	}
}
