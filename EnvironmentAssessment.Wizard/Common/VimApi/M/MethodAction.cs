namespace EnvironmentAssessment.Common.VimApi
{
	public class MethodAction : Action
	{
		protected string _name;
		protected MethodActionArgument[] _argument;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public MethodActionArgument[] Argument
		{
			get
			{
				return this._argument;
			}
			set
			{
				this._argument = value;
			}
		}
	}
}
