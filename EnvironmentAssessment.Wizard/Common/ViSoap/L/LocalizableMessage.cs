namespace EnvironmentAssessment.Common.VISoap
{
    public class LocalizableMessage : DynamicData
	{
		protected string _key;
		protected KeyAnyValue[] _arg;
		protected string _message;
		public string Key
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
		public KeyAnyValue[] Arg
		{
			get
			{
				return this._arg;
			}
			set
			{
				this._arg = value;
			}
		}
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}
	}
}
