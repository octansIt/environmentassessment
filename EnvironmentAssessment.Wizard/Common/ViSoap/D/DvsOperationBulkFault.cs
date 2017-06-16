namespace EnvironmentAssessment.Common.VISoap
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
