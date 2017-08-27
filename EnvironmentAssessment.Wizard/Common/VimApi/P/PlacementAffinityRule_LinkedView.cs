namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementAffinityRule_LinkedView
	{
		protected VirtualMachine[] _vms;
		public VirtualMachine[] Vms
		{
			get
			{
				return this._vms;
			}
			set
			{
				this._vms = value;
			}
		}
	}
}
