namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSSummary_LinkedView
	{
		protected HostSystem[] _hostMember;
		protected VirtualMachine[] _vm;
		protected HostSystem[] _host;
		public HostSystem[] HostMember
		{
			get
			{
				return this._hostMember;
			}
			set
			{
				this._hostMember = value;
			}
		}
		public VirtualMachine[] Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public HostSystem[] Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
	}
}
