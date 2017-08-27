namespace EnvironmentAssessment.Common.VimApi
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
