namespace EnvironmentAssessment.Common.VISoap
{
    public class VmConfigFileInfo : FileInfo
	{
		protected int? _configVersion;
		public int? ConfigVersion
		{
			get
			{
				return this._configVersion;
			}
			set
			{
				this._configVersion = value;
			}
		}
	}
}
