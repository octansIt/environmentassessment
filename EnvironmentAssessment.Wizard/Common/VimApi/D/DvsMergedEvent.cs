namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsMergedEvent : DvsEvent
	{
		protected DvsEventArgument _sourceDvs;
		protected DvsEventArgument _destinationDvs;
		public DvsEventArgument SourceDvs
		{
			get
			{
				return this._sourceDvs;
			}
			set
			{
				this._sourceDvs = value;
			}
		}
		public DvsEventArgument DestinationDvs
		{
			get
			{
				return this._destinationDvs;
			}
			set
			{
				this._destinationDvs = value;
			}
		}
	}
}
