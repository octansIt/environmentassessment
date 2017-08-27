namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsOperationBulkFault : DvsFault
	{
		protected DvsOperationBulkFaultFaultOnHost[] _hostFault;
		public DvsOperationBulkFaultFaultOnHost[] HostFault
		{
			get
			{
				return this._hostFault;
			}
			set
			{
				this._hostFault = value;
			}
		}
	}
}
