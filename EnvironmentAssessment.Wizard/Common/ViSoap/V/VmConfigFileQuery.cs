namespace EnvironmentAssessment.Common.VISoap
{
    public class VmConfigFileQuery : FileQuery
	{
		protected VmConfigFileQueryFilter _filter;
		protected VmConfigFileQueryFlags _details;
		public VmConfigFileQueryFilter Filter
		{
			get
			{
				return this._filter;
			}
			set
			{
				this._filter = value;
			}
		}
		public VmConfigFileQueryFlags Details
		{
			get
			{
				return this._details;
			}
			set
			{
				this._details = value;
			}
		}
	}
}
