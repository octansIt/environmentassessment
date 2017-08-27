namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceConfigSpec : DynamicData
	{
		protected FaultToleranceMetaSpec _metaDataPath;
		protected FaultToleranceVMConfigSpec _secondaryVmSpec;
		public FaultToleranceMetaSpec MetaDataPath
		{
			get
			{
				return this._metaDataPath;
			}
			set
			{
				this._metaDataPath = value;
			}
		}
		public FaultToleranceVMConfigSpec SecondaryVmSpec
		{
			get
			{
				return this._secondaryVmSpec;
			}
			set
			{
				this._secondaryVmSpec = value;
			}
		}
	}
}
