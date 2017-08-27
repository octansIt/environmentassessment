namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineCdromInfo : VirtualMachineTargetInfo
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
