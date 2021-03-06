namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDasVmConfigInfo : DynamicData
	{
		protected ManagedObjectReference _key;
		protected DasVmPriority? _restartPriority;
		protected bool? _powerOffOnIsolation;
		protected ClusterDasVmSettings _dasSettings;
		protected ClusterDasVmConfigInfo_LinkedView _linkedView;
		public ManagedObjectReference Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public DasVmPriority? RestartPriority
		{
			get
			{
				return this._restartPriority;
			}
			set
			{
				this._restartPriority = value;
			}
		}
		public bool? PowerOffOnIsolation
		{
			get
			{
				return this._powerOffOnIsolation;
			}
			set
			{
				this._powerOffOnIsolation = value;
			}
		}
		public ClusterDasVmSettings DasSettings
		{
			get
			{
				return this._dasSettings;
			}
			set
			{
				this._dasSettings = value;
			}
		}
		public ClusterDasVmConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
