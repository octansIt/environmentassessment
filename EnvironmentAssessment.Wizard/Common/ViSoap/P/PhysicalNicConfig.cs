namespace EnvironmentAssessment.Common.VISoap
{
    public class PhysicalNicConfig : DynamicData
	{
		protected string _device;
		protected PhysicalNicSpec _spec;
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
		public PhysicalNicSpec Spec
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
