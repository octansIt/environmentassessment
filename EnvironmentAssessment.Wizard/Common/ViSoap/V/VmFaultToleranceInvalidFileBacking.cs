namespace EnvironmentAssessment.Common.VISoap
{
    public class VmFaultToleranceInvalidFileBacking : VmFaultToleranceIssue
	{
		protected string _backingType;
		protected string _backingFilename;
		public string BackingType
		{
			get
			{
				return this._backingType;
			}
			set
			{
				this._backingType = value;
			}
		}
		public string BackingFilename
		{
			get
			{
				return this._backingFilename;
			}
			set
			{
				this._backingFilename = value;
			}
		}
	}
}
