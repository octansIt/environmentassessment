namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualPS2ControllerOption : VirtualControllerOption
	{
		protected IntOption _numKeyboards;
		protected IntOption _numPointingDevices;
		public IntOption NumKeyboards
		{
			get
			{
				return this._numKeyboards;
			}
			set
			{
				this._numKeyboards = value;
			}
		}
		public IntOption NumPointingDevices
		{
			get
			{
				return this._numPointingDevices;
			}
			set
			{
				this._numPointingDevices = value;
			}
		}
	}
}
