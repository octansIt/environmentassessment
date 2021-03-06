namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceConfigInfo : DynamicData
	{
		protected int _role;
		protected string[] _instanceUuids;
		protected string[] _configPaths;
		protected bool? _orphaned;
		public int Role
		{
			get
			{
				return this._role;
			}
			set
			{
				this._role = value;
			}
		}
		public string[] InstanceUuids
		{
			get
			{
				return this._instanceUuids;
			}
			set
			{
				this._instanceUuids = value;
			}
		}
		public string[] ConfigPaths
		{
			get
			{
				return this._configPaths;
			}
			set
			{
				this._configPaths = value;
			}
		}
		public bool? Orphaned
		{
			get
			{
				return this._orphaned;
			}
			set
			{
				this._orphaned = value;
			}
		}
	}
}
