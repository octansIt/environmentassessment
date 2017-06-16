namespace EnvironmentAssessment.Common.VISoap
{
    public class TaskDescription : DynamicData
	{
		protected ElementDescription[] _methodInfo;
		protected ElementDescription[] _state;
		protected TypeDescription[] _reason;
		public ElementDescription[] MethodInfo
		{
			get
			{
				return this._methodInfo;
			}
			set
			{
				this._methodInfo = value;
			}
		}
		public ElementDescription[] State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public TypeDescription[] Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}
