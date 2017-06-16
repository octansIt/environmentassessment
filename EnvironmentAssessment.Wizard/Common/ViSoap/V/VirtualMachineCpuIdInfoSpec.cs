namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineCpuIdInfoSpec : ArrayUpdateSpec
	{
		protected HostCpuIdInfo _info;
		public HostCpuIdInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
