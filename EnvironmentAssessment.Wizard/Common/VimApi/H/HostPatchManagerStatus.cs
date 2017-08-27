namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPatchManagerStatus : DynamicData
	{
		protected string _id;
		protected bool _applicable;
		protected string[] _reason;
		protected string _integrity;
		protected bool _installed;
		protected string[] _installState;
		protected HostPatchManagerStatusPrerequisitePatch[] _prerequisitePatch;
		protected bool _restartRequired;
		protected bool _reconnectRequired;
		protected bool _vmOffRequired;
		protected string[] _supersededPatchIds;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public bool Applicable
		{
			get
			{
				return this._applicable;
			}
			set
			{
				this._applicable = value;
			}
		}
		public string[] Reason
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
		public string Integrity
		{
			get
			{
				return this._integrity;
			}
			set
			{
				this._integrity = value;
			}
		}
		public bool Installed
		{
			get
			{
				return this._installed;
			}
			set
			{
				this._installed = value;
			}
		}
		public string[] InstallState
		{
			get
			{
				return this._installState;
			}
			set
			{
				this._installState = value;
			}
		}
		public HostPatchManagerStatusPrerequisitePatch[] PrerequisitePatch
		{
			get
			{
				return this._prerequisitePatch;
			}
			set
			{
				this._prerequisitePatch = value;
			}
		}
		public bool RestartRequired
		{
			get
			{
				return this._restartRequired;
			}
			set
			{
				this._restartRequired = value;
			}
		}
		public bool ReconnectRequired
		{
			get
			{
				return this._reconnectRequired;
			}
			set
			{
				this._reconnectRequired = value;
			}
		}
		public bool VmOffRequired
		{
			get
			{
				return this._vmOffRequired;
			}
			set
			{
				this._vmOffRequired = value;
			}
		}
		public string[] SupersededPatchIds
		{
			get
			{
				return this._supersededPatchIds;
			}
			set
			{
				this._supersededPatchIds = value;
			}
		}
	}
}
