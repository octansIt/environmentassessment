namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDrsVmConfigInfo : DynamicData
	{
		protected ManagedObjectReference _key;
		protected bool? _enabled;
		protected DrsBehavior? _behavior;
		protected ClusterDrsVmConfigInfo_LinkedView _linkedView;
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
		public DrsBehavior? Behavior
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
		public ClusterDrsVmConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
