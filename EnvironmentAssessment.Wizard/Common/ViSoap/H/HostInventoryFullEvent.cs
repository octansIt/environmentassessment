namespace EnvironmentAssessment.Common.VISoap
{
    public class HostInventoryFullEvent : LicenseEvent
	{
		protected int _capacity;
		public int Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				this._capacity = value;
			}
		}
	}
}
