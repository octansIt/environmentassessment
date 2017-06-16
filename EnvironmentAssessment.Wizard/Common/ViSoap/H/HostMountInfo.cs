namespace EnvironmentAssessment.Common.VISoap
{
    public class HostMountInfo : DynamicData
	{
		protected string _path;
		protected string _accessMode;
		protected bool? _mounted;
		protected bool? _accessible;
		protected string _inaccessibleReason;
		public string Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
		public string AccessMode
		{
			get
			{
				return this._accessMode;
			}
			set
			{
				this._accessMode = value;
			}
		}
		public bool? Mounted
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
		public bool? Accessible
		{
			get
			{
				return this._accessible;
			}
			set
			{
				this._accessible = value;
			}
		}
		public string InaccessibleReason
		{
			get
			{
				return this._inaccessibleReason;
			}
			set
			{
				this._inaccessibleReason = value;
			}
		}
	}
}
