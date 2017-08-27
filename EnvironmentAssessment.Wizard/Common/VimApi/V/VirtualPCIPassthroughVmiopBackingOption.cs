namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualPCIPassthroughVmiopBackingOption : VirtualPCIPassthroughPluginBackingOption
	{
		protected StringOption _vgpu;
		protected int _maxInstances;
		public StringOption Vgpu
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
		public int MaxInstances
		{
			get
			{
				return this._maxInstances;
			}
			set
			{
				this._maxInstances = value;
			}
		}
	}
}
