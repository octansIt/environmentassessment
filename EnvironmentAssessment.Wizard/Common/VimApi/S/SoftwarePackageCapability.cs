namespace EnvironmentAssessment.Common.VimApi
{
	public class SoftwarePackageCapability : DynamicData
	{
		protected bool? _liveInstallAllowed;
		protected bool? _liveRemoveAllowed;
		protected bool? _statelessReady;
		protected bool? _overlay;
		public bool? LiveInstallAllowed
		{
			get
			{
				return this._liveInstallAllowed;
			}
			set
			{
				this._liveInstallAllowed = value;
			}
		}
		public bool? LiveRemoveAllowed
		{
			get
			{
				return this._liveRemoveAllowed;
			}
			set
			{
				this._liveRemoveAllowed = value;
			}
		}
		public bool? StatelessReady
		{
			get
			{
				return this._statelessReady;
			}
			set
			{
				this._statelessReady = value;
			}
		}
		public bool? Overlay
		{
			get
			{
				return this._overlay;
			}
			set
			{
				this._overlay = value;
			}
		}
	}
}
