namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfile_LinkedView : Profile_LinkedView
	{
		protected HostSystem _referenceHost;
		public HostSystem ReferenceHost
		{
			get
			{
				return this._referenceHost;
			}
		}
	}
}
