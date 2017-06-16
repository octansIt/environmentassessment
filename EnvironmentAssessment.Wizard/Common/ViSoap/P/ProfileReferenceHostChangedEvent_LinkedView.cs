namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileReferenceHostChangedEvent_LinkedView
	{
		protected HostSystem _referenceHost;
		public HostSystem ReferenceHost
		{
			get
			{
				return this._referenceHost;
			}
			set
			{
				this._referenceHost = value;
			}
		}
	}
}
