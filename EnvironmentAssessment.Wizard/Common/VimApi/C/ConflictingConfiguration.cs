namespace EnvironmentAssessment.Common.VimApi
{
	public class ConflictingConfiguration : DvsFault
	{
		protected ConflictingConfigurationConfig[] _configInConflict;
		public ConflictingConfigurationConfig[] ConfigInConflict
		{
			get
			{
				return this._configInConflict;
			}
			set
			{
				this._configInConflict = value;
			}
		}
	}
}
