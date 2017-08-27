namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualNicConfig : DynamicData
	{
		protected string _changeOperation;
		protected string _device;
		protected string _portgroup;
		protected HostVirtualNicSpec _spec;
		public string ChangeOperation
		{
			get
			{
				return this._changeOperation;
			}
			set
			{
				this._changeOperation = value;
			}
		}
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public string Portgroup
		{
			get
			{
				return this._portgroup;
			}
			set
			{
				this._portgroup = value;
			}
		}
		public HostVirtualNicSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
	}
}
