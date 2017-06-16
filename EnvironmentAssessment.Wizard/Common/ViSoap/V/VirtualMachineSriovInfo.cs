namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineSriovInfo : VirtualMachinePciPassthroughInfo
	{
		protected bool _virtualFunction;
		protected string _pnic;
		public bool VirtualFunction
		{
			get
			{
				return this._virtualFunction;
			}
			set
			{
				this._virtualFunction = value;
			}
		}
		public string Pnic
		{
			get
			{
				return this._pnic;
			}
			set
			{
				this._pnic = value;
			}
		}
	}
}
