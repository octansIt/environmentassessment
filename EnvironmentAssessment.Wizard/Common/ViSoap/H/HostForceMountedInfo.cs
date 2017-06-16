namespace EnvironmentAssessment.Common.VISoap
{
    public class HostForceMountedInfo : DynamicData
	{
		protected bool _persist;
		protected bool _mounted;
		public bool Persist
		{
			get
			{
				return this._persist;
			}
			set
			{
				this._persist = value;
			}
		}
		public bool Mounted
		{
			get
			{
				return this._mounted;
			}
			set
			{
				this._mounted = value;
			}
		}
	}
}
