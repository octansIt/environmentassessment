namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualSriovEthernetCardSriovBackingInfo : VirtualDeviceBackingInfo
	{
		protected VirtualPCIPassthroughDeviceBackingInfo _physicalFunctionBacking;
		protected VirtualPCIPassthroughDeviceBackingInfo _virtualFunctionBacking;
		protected int? _virtualFunctionIndex;
		public VirtualPCIPassthroughDeviceBackingInfo PhysicalFunctionBacking
		{
			get
			{
				return this._physicalFunctionBacking;
			}
			set
			{
				this._physicalFunctionBacking = value;
			}
		}
		public VirtualPCIPassthroughDeviceBackingInfo VirtualFunctionBacking
		{
			get
			{
				return this._virtualFunctionBacking;
			}
			set
			{
				this._virtualFunctionBacking = value;
			}
		}
		public int? VirtualFunctionIndex
		{
			get
			{
				return this._virtualFunctionIndex;
			}
			set
			{
				this._virtualFunctionIndex = value;
			}
		}
	}
}
