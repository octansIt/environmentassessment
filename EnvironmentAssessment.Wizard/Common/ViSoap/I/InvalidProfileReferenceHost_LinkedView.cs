namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidProfileReferenceHost_LinkedView
	{
		protected HostSystem _host;
		protected Profile _profile;
		public HostSystem Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public Profile Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
			}
		}
	}
}
