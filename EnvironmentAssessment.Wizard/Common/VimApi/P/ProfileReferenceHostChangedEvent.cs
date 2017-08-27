namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileReferenceHostChangedEvent : ProfileEvent
	{
		protected ManagedObjectReference _referenceHost;
		protected string _referenceHostName;
		protected string _prevReferenceHostName;
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
		public string ReferenceHostName
		{
			get
			{
				return this._referenceHostName;
			}
			set
			{
				this._referenceHostName = value;
			}
		}
		public string PrevReferenceHostName
		{
			get
			{
				return this._prevReferenceHostName;
			}
			set
			{
				this._prevReferenceHostName = value;
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
