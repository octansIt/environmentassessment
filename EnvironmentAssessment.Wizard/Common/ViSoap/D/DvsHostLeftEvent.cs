namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsHostLeftEvent : DvsEvent
	{
		protected HostEventArgument _hostLeft;
		public HostEventArgument HostLeft
		{
			get
			{
				return this._hostLeft;
			}
			set
			{
				this._hostLeft = value;
			}
		}
	}
}
