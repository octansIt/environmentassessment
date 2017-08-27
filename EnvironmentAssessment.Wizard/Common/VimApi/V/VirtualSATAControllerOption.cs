namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualSATAControllerOption : VirtualControllerOption
	{
		protected IntOption _numSATADisks;
		protected IntOption _numSATACdroms;
		public IntOption NumSATADisks
		{
			get
			{
				return this._numSATADisks;
			}
			set
			{
				this._numSATADisks = value;
			}
		}
		public IntOption NumSATACdroms
		{
			get
			{
				return this._numSATACdroms;
			}
			set
			{
				this._numSATACdroms = value;
			}
		}
	}
}
