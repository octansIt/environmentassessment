namespace EnvironmentAssessment.Common.VimApi
{
	public class UnlicensedVirtualMachinesFoundEvent : LicenseEvent
	{
		protected int _available;
		public int Available
		{
			get
			{
				return this._available;
			}
			set
			{
				this._available = value;
			}
		}
	}
}
