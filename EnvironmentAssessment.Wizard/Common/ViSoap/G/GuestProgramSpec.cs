namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestProgramSpec : DynamicData
	{
		protected string _programPath;
		protected string _arguments;
		protected string _workingDirectory;
		protected string[] _envVariables;
		public string ProgramPath
		{
			get
			{
				return this._programPath;
			}
			set
			{
				this._programPath = value;
			}
		}
		public string Arguments
		{
			get
			{
				return this._arguments;
			}
			set
			{
				this._arguments = value;
			}
		}
		public string WorkingDirectory
		{
			get
			{
				return this._workingDirectory;
			}
			set
			{
				this._workingDirectory = value;
			}
		}
		public string[] EnvVariables
		{
			get
			{
				return this._envVariables;
			}
			set
			{
				this._envVariables = value;
			}
		}
	}
}
