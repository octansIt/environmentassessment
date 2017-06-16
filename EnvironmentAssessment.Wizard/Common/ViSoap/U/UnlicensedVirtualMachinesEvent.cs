namespace EnvironmentAssessment.Common.VISoap
{
    public class UnlicensedVirtualMachinesEvent : LicenseEvent
	{
		protected int _unlicensed;
		protected int _available;
		public int Unlicensed
		{
			get
			{
				return this._unlicensed;
			}
			set
			{
				this._unlicensed = value;
			}
		}
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
