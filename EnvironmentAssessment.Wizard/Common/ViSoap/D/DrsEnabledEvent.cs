namespace EnvironmentAssessment.Common.VISoap
{
    public class DrsEnabledEvent : ClusterEvent
	{
		protected string _behavior;
		public string Behavior
		{
			get
			{
				return this._behavior;
			}
			set
			{
				this._behavior = value;
			}
		}
	}
}
