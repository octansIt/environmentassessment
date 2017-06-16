namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfConsumerCommunicationError : OvfConsumerCallbackFault
	{
		protected string _description;
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
