namespace EnvironmentAssessment.Common.VimApi
{
	public class DatacenterEventArgument_LinkedView
	{
		protected Datacenter _datacenter;
		public Datacenter Datacenter
		{
			get
			{
				return this._datacenter;
			}
			set
			{
				this._datacenter = value;
			}
		}
	}
}
