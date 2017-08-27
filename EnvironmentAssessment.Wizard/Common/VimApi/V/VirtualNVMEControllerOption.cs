namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualNVMEControllerOption : VirtualControllerOption
	{
		protected IntOption _numNVMEDisks;
		public IntOption NumNVMEDisks
		{
			get
			{
				return this._numNVMEDisks;
			}
			set
			{
				this._numNVMEDisks = value;
			}
		}
	}
}
