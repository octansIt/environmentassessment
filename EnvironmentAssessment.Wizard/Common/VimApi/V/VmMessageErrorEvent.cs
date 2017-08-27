namespace EnvironmentAssessment.Common.VimApi
{
	public class VmMessageErrorEvent : VmEvent
	{
		protected string _message;
		protected VirtualMachineMessage[] _messageInfo;
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
		public VirtualMachineMessage[] MessageInfo
		{
			get
			{
				return this._messageInfo;
			}
			set
			{
				this._messageInfo = value;
			}
		}
	}
}
