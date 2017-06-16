namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualSIOControllerOption : VirtualControllerOption
	{
		protected IntOption _numFloppyDrives;
		protected IntOption _numSerialPorts;
		protected IntOption _numParallelPorts;
		public IntOption NumFloppyDrives
		{
			get
			{
				return this._numFloppyDrives;
			}
			set
			{
				this._numFloppyDrives = value;
			}
		}
		public IntOption NumSerialPorts
		{
			get
			{
				return this._numSerialPorts;
			}
			set
			{
				this._numSerialPorts = value;
			}
		}
		public IntOption NumParallelPorts
		{
			get
			{
				return this._numParallelPorts;
			}
			set
			{
				this._numParallelPorts = value;
			}
		}
	}
}
