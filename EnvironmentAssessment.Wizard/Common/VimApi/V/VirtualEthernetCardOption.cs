namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualEthernetCardOption : VirtualDeviceOption
	{
		protected ChoiceOption _supportedOUI;
		protected ChoiceOption _macType;
		protected BoolOption _wakeOnLanEnabled;
		protected bool _vmDirectPathGen2Supported;
		protected BoolOption _uptCompatibilityEnabled;
		public ChoiceOption SupportedOUI
		{
			get
			{
				return this._supportedOUI;
			}
			set
			{
				this._supportedOUI = value;
			}
		}
		public ChoiceOption MacType
		{
			get
			{
				return this._macType;
			}
			set
			{
				this._macType = value;
			}
		}
		public BoolOption WakeOnLanEnabled
		{
			get
			{
				return this._wakeOnLanEnabled;
			}
			set
			{
				this._wakeOnLanEnabled = value;
			}
		}
		public bool VmDirectPathGen2Supported
		{
			get
			{
				return this._vmDirectPathGen2Supported;
			}
			set
			{
				this._vmDirectPathGen2Supported = value;
			}
		}
		public BoolOption UptCompatibilityEnabled
		{
			get
			{
				return this._uptCompatibilityEnabled;
			}
			set
			{
				this._uptCompatibilityEnabled = value;
			}
		}
	}
}
