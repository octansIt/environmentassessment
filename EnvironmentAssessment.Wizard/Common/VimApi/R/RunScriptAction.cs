namespace EnvironmentAssessment.Common.VimApi
{
	public class RunScriptAction : Action
	{
		protected string _script;
		public string Script
		{
			get
			{
				return this._script;
			}
			set
			{
				this._script = value;
			}
		}
	}
}
