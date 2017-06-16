namespace EnvironmentAssessment.Common.VISoap
{
    public class VsanHostDiskMapResult : DynamicData
	{
		protected VsanHostDiskMapping _mapping;
		protected VsanHostDiskResult[] _diskResult;
		protected LocalizedMethodFault _error;
		public VsanHostDiskMapping Mapping
		{
			get
			{
				return this._mapping;
			}
			set
			{
				this._mapping = value;
			}
		}
		public VsanHostDiskResult[] DiskResult
		{
			get
			{
				return this._diskResult;
			}
			set
			{
				this._diskResult = value;
			}
		}
		public LocalizedMethodFault Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
	}
}
