namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineMessage : DynamicData
	{
		protected string _id;
		protected object[] _argument;
		protected string _text;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public object[] Argument
		{
			get
			{
				return this._argument;
			}
			set
			{
				this._argument = value;
			}
		}
		public string Text
		{
			get
			{
				return this._text;
			}
			set
			{
				this._text = value;
			}
		}
	}
}
