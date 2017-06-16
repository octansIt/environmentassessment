namespace EnvironmentAssessment.Common.VISoap
{
    public class VmDiskFileQueryFilter : DynamicData
	{
		protected string[] _diskType;
		protected int[] _matchHardwareVersion;
		protected string[] _controllerType;
		protected bool? _thin;
		public string[] DiskType
		{
			get
			{
				return this._diskType;
			}
			set
			{
				this._diskType = value;
			}
		}
		public int[] MatchHardwareVersion
		{
			get
			{
				return this._matchHardwareVersion;
			}
			set
			{
				this._matchHardwareVersion = value;
			}
		}
		public string[] ControllerType
		{
			get
			{
				return this._controllerType;
			}
			set
			{
				this._controllerType = value;
			}
		}
		public bool? Thin
		{
			get
			{
				return this._thin;
			}
			set
			{
				this._thin = value;
			}
		}
	}
}
