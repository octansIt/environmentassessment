namespace EnvironmentAssessment.Common.VISoap
{
    public class VmMacChangedEvent : VmEvent
	{
		protected string _adapter;
		protected string _oldMac;
		protected string _newMac;
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
		public string OldMac
		{
			get
			{
				return this._oldMac;
			}
			set
			{
				this._oldMac = value;
			}
		}
		public string NewMac
		{
			get
			{
				return this._newMac;
			}
			set
			{
				this._newMac = value;
			}
		}
	}
}
