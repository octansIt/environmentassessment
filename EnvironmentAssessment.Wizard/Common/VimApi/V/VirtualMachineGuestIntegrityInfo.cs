namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineGuestIntegrityInfo : DynamicData
	{
		protected bool? _enabled;
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
	}
}
