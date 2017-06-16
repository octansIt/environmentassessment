namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileReferenceHostChangedEvent : ProfileEvent
	{
		protected ManagedObjectReference _referenceHost;
		protected ProfileReferenceHostChangedEvent_LinkedView _linkedView;
		public ManagedObjectReference ReferenceHost
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
		public ProfileReferenceHostChangedEvent_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
