namespace EnvironmentAssessment.Common.VimApi
{
	public class ComputeResourceConfigSpec : DynamicData
	{
		protected string _vmSwapPlacement;
		protected bool? _spbmEnabled;
		protected string _defaultHardwareVersionKey;
		public string VmSwapPlacement
		{
			get
			{
				return this._vmSwapPlacement;
			}
			set
			{
				this._vmSwapPlacement = value;
			}
		}
		public bool? SpbmEnabled
		{
			get
			{
				return this._spbmEnabled;
			}
			set
			{
				this._spbmEnabled = value;
			}
		}
		public string DefaultHardwareVersionKey
		{
			get
			{
				return this._defaultHardwareVersionKey;
			}
			set
			{
				this._defaultHardwareVersionKey = value;
			}
		}
	}
}
