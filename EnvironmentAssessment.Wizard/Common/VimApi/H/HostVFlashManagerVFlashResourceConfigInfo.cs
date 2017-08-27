namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVFlashManagerVFlashResourceConfigInfo : DynamicData
	{
		protected HostVffsVolume _vffs;
		protected long _capacity;
		public HostVffsVolume Vffs
		{
			get
			{
				return this._vffs;
			}
			set
			{
				this._vffs = value;
			}
		}
		public long Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				this._capacity = value;
			}
		}
	}
}
