namespace EnvironmentAssessment.Common.VimApi
{
	public class HostTpmOptionEventDetails : HostTpmEventDetails
	{
		protected string _optionsFileName;
		protected sbyte[] _bootOptions;
		public string OptionsFileName
		{
			get
			{
				return this._optionsFileName;
			}
			set
			{
				this._optionsFileName = value;
			}
		}
		public sbyte[] BootOptions
		{
			get
			{
				return this._bootOptions;
			}
			set
			{
				this._bootOptions = value;
			}
		}
	}
}
