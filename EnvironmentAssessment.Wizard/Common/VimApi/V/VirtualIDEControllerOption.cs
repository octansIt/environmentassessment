namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualIDEControllerOption : VirtualControllerOption
	{
		protected IntOption _numIDEDisks;
		protected IntOption _numIDECdroms;
		public IntOption NumIDEDisks
		{
			get
			{
				return this._numIDEDisks;
			}
			set
			{
				this._numIDEDisks = value;
			}
		}
		public IntOption NumIDECdroms
		{
			get
			{
				return this._numIDECdroms;
			}
			set
			{
				this._numIDECdroms = value;
			}
		}
	}
}
