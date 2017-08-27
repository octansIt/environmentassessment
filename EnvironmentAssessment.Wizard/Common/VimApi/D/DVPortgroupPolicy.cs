namespace EnvironmentAssessment.Common.VimApi
{
	public class DVPortgroupPolicy : DynamicData
	{
		protected bool _blockOverrideAllowed;
		protected bool _shapingOverrideAllowed;
		protected bool _vendorConfigOverrideAllowed;
		protected bool _livePortMovingAllowed;
		protected bool _portConfigResetAtDisconnect;
		protected bool? _networkResourcePoolOverrideAllowed;
		protected bool? _trafficFilterOverrideAllowed;
		public bool BlockOverrideAllowed
		{
			get
			{
				return this._blockOverrideAllowed;
			}
			set
			{
				this._blockOverrideAllowed = value;
			}
		}
		public bool ShapingOverrideAllowed
		{
			get
			{
				return this._shapingOverrideAllowed;
			}
			set
			{
				this._shapingOverrideAllowed = value;
			}
		}
		public bool VendorConfigOverrideAllowed
		{
			get
			{
				return this._vendorConfigOverrideAllowed;
			}
			set
			{
				this._vendorConfigOverrideAllowed = value;
			}
		}
		public bool LivePortMovingAllowed
		{
			get
			{
				return this._livePortMovingAllowed;
			}
			set
			{
				this._livePortMovingAllowed = value;
			}
		}
		public bool PortConfigResetAtDisconnect
		{
			get
			{
				return this._portConfigResetAtDisconnect;
			}
			set
			{
				this._portConfigResetAtDisconnect = value;
			}
		}
		public bool? NetworkResourcePoolOverrideAllowed
		{
			get
			{
				return this._networkResourcePoolOverrideAllowed;
			}
			set
			{
				this._networkResourcePoolOverrideAllowed = value;
			}
		}
		public bool? TrafficFilterOverrideAllowed
		{
			get
			{
				return this._trafficFilterOverrideAllowed;
			}
			set
			{
				this._trafficFilterOverrideAllowed = value;
			}
		}
	}
}
