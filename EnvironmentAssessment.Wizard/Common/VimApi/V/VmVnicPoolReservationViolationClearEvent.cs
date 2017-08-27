namespace EnvironmentAssessment.Common.VimApi
{
	public class VmVnicPoolReservationViolationClearEvent : DvsEvent
	{
		protected string _vmVnicResourcePoolKey;
		protected string _vmVnicResourcePoolName;
		public string VmVnicResourcePoolKey
		{
			get
			{
				return this._vmVnicResourcePoolKey;
			}
			set
			{
				this._vmVnicResourcePoolKey = value;
			}
		}
		public string VmVnicResourcePoolName
		{
			get
			{
				return this._vmVnicResourcePoolName;
			}
			set
			{
				this._vmVnicResourcePoolName = value;
			}
		}
	}
}
