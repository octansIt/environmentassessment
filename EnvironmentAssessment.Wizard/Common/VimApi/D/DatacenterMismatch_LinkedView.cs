namespace EnvironmentAssessment.Common.VimApi
{
	public class DatacenterMismatch_LinkedView
	{
		protected Datacenter _expectedDatacenter;
		public Datacenter ExpectedDatacenter
		{
			get
			{
				return this._expectedDatacenter;
			}
			set
			{
				this._expectedDatacenter = value;
			}
		}
	}
}
