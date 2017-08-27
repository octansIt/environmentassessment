namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmTriggeringActionTransitionSpec : DynamicData
	{
		protected ManagedEntityStatus _startState;
		protected ManagedEntityStatus _finalState;
		protected bool _repeats;
		public ManagedEntityStatus StartState
		{
			get
			{
				return this._startState;
			}
			set
			{
				this._startState = value;
			}
		}
		public ManagedEntityStatus FinalState
		{
			get
			{
				return this._finalState;
			}
			set
			{
				this._finalState = value;
			}
		}
		public bool Repeats
		{
			get
			{
				return this._repeats;
			}
			set
			{
				this._repeats = value;
			}
		}
	}
}
