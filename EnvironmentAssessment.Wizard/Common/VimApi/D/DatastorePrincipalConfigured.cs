namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastorePrincipalConfigured : HostEvent
	{
		protected string _datastorePrincipal;
		public string DatastorePrincipal
		{
			get
			{
				return this._datastorePrincipal;
			}
			set
			{
				this._datastorePrincipal = value;
			}
		}
	}
}
