namespace EnvironmentAssessment.Common.VISoap
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
