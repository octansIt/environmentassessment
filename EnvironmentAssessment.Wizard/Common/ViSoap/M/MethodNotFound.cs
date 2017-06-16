namespace EnvironmentAssessment.Common.VISoap
{
    public class MethodNotFound : InvalidRequest
	{
		protected ManagedObjectReference _receiver;
		protected string _method;
		public ManagedObjectReference Receiver
		{
			get
			{
				return this._receiver;
			}
			set
			{
				this._receiver = value;
			}
		}
		public string Method
		{
			get
			{
				return this._method;
			}
			set
			{
				this._method = value;
			}
		}
	}
}
