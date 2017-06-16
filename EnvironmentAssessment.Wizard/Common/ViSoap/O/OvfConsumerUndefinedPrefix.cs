namespace EnvironmentAssessment.Common.VISoap
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
