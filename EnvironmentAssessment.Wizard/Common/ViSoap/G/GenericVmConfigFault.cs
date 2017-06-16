namespace EnvironmentAssessment.Common.VISoap
{
    public class GenericVmConfigFault : VmConfigFault
	{
		protected string _reason;
		protected VirtualMachineMessage[] _messageInfo;
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
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
