namespace EnvironmentAssessment.Common.VimApi
{
	public class HostConfigFailed : HostConfigFault
	{
		protected LocalizedMethodFault[] _failure;
		public LocalizedMethodFault[] Failure
		{
			get
			{
				return this._failure;
			}
			set
			{
				this._failure = value;
			}
		}
	}
}
