namespace EnvironmentAssessment.Common.VimApi
{
	public class VmDiskFileQuery : FileQuery
	{
		protected VmDiskFileQueryFilter _filter;
		protected VmDiskFileQueryFlags _details;
		public VmDiskFileQueryFilter Filter
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
		public VmDiskFileQueryFlags Details
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
