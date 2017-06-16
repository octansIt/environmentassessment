namespace EnvironmentAssessment.Common.VISoap
{
    public class VmfsDatastoreOption : DynamicData
	{
		protected VmfsDatastoreBaseOption _info;
		protected VmfsDatastoreSpec _spec;
		public VmfsDatastoreBaseOption Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
		public VmfsDatastoreSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
	}
}
