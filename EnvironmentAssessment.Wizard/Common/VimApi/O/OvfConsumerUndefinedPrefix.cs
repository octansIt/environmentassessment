namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfConsumerUndefinedPrefix : OvfConsumerCallbackFault
	{
		protected string _prefix;
		public string Prefix
		{
			get
			{
				return this._prefix;
			}
			set
			{
				this._prefix = value;
			}
		}
	}
}
