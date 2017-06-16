namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineDeviceRuntimeInfo : DynamicData
	{
		protected VirtualMachineDeviceRuntimeInfoDeviceRuntimeState _runtimeState;
		protected int _key;
		public VirtualMachineDeviceRuntimeInfoDeviceRuntimeState RuntimeState
		{
			get
			{
				return this._runtimeState;
			}
			set
			{
				this._runtimeState = value;
			}
		}
		public int Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
	}
}
