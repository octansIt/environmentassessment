namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultTolerancePrimaryConfigInfo_LinkedView
	{
		protected VirtualMachine[] _secondaries;
		public VirtualMachine[] Secondaries
		{
			get
			{
				return this._secondaries;
			}
			set
			{
				this._secondaries = value;
			}
		}
	}
}
