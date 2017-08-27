namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineGuestQuiesceSpec : DynamicData
	{
		protected int? _timeout;
		public int? Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				this._timeout = value;
			}
		}
	}
}
