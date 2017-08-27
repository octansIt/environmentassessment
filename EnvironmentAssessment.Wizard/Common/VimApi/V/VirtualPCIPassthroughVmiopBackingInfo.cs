namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualPCIPassthroughVmiopBackingInfo : VirtualPCIPassthroughPluginBackingInfo
	{
		protected string _vgpu;
		public string Vgpu
		{
			get
			{
				return this._vgpu;
			}
			set
			{
				this._vgpu = value;
			}
		}
	}
}
