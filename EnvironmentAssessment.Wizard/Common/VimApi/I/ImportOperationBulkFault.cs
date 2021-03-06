namespace EnvironmentAssessment.Common.VimApi
{
	public class ImportOperationBulkFault : DvsFault
	{
		protected ImportOperationBulkFaultFaultOnImport[] _importFaults;
		public ImportOperationBulkFaultFaultOnImport[] ImportFaults
		{
			get
			{
				return this._importFaults;
			}
			set
			{
				this._importFaults = value;
			}
		}
	}
}
