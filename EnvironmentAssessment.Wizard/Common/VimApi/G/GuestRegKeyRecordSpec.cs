namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegKeyRecordSpec : DynamicData
	{
		protected GuestRegKeySpec _key;
		protected LocalizedMethodFault _fault;
		public GuestRegKeySpec Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
