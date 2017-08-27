namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineQuestionInfo : DynamicData
	{
		protected string _id;
		protected string _text;
		protected ChoiceOption _choice;
		protected VirtualMachineMessage[] _message;
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
		public ChoiceOption Choice
		{
			get
			{
				return this._choice;
			}
			set
			{
				this._choice = value;
			}
		}
		public VirtualMachineMessage[] Message
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
