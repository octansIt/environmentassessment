namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmTriggeringAction : AlarmAction
	{
		protected Action _action;
		protected AlarmTriggeringActionTransitionSpec[] _transitionSpecs;
		protected bool _green2yellow;
		protected bool _yellow2red;
		protected bool _red2yellow;
		protected bool _yellow2green;
		public Action Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}
		public AlarmTriggeringActionTransitionSpec[] TransitionSpecs
		{
			get
			{
				return this._transitionSpecs;
			}
			set
			{
				this._transitionSpecs = value;
			}
		}
		public bool Green2yellow
		{
			get
			{
				return this._green2yellow;
			}
			set
			{
				this._green2yellow = value;
			}
		}
		public bool Yellow2red
		{
			get
			{
				return this._yellow2red;
			}
			set
			{
				this._yellow2red = value;
			}
		}
		public bool Red2yellow
		{
			get
			{
				return this._red2yellow;
			}
			set
			{
				this._red2yellow = value;
			}
		}
		public bool Yellow2green
		{
			get
			{
				return this._yellow2green;
			}
			set
			{
				this._yellow2green = value;
			}
		}
	}
}
