namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceSecondaryConfigInfo_LinkedView
	{
		protected VirtualMachine _primaryVM;
		public VirtualMachine PrimaryVM
		{
			get
			{
				return this._primaryVM;
			}
			set
			{
				this._primaryVM = value;
			}
		}
	}
}
