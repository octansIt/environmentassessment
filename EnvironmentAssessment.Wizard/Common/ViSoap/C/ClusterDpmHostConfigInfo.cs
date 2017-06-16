namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDpmHostConfigInfo : DynamicData
	{
		protected ManagedObjectReference _key;
		protected bool? _enabled;
		protected DpmBehavior? _behavior;
		protected ClusterDpmHostConfigInfo_LinkedView _linkedView;
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
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public DpmBehavior? Behavior
		{
			get
			{
				return this._behavior;
			}
			set
			{
				this._behavior = value;
			}
		}
		public ClusterDpmHostConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
