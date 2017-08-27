namespace EnvironmentAssessment.Common.VimApi
{
	public class SourceNodeSpec_LinkedView
	{
		protected VirtualMachine _activeVc;
		public VirtualMachine ActiveVc
		{
			get
			{
				return this._activeVc;
			}
			set
			{
				this._activeVc = value;
			}
		}
	}
}
