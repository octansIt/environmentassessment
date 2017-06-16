namespace EnvironmentAssessment.Common.VISoap
{
    public class DatacenterCreatedEvent : DatacenterEvent
	{
		protected FolderEventArgument _parent;
		public FolderEventArgument Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				this._parent = value;
			}
		}
	}
}
