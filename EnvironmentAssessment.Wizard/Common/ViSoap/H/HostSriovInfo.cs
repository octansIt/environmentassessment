namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSriovInfo : HostPciPassthruInfo
	{
		protected bool _sriovEnabled;
		protected bool _sriovCapable;
		protected bool _sriovActive;
		protected int _numVirtualFunctionRequested;
		protected int _numVirtualFunction;
		protected int _maxVirtualFunctionSupported;
		public bool SriovEnabled
		{
			get
			{
				return this._sriovEnabled;
			}
			set
			{
				this._sriovEnabled = value;
			}
		}
		public bool SriovCapable
		{
			get
			{
				return this._sriovCapable;
			}
			set
			{
				this._sriovCapable = value;
			}
		}
		public bool SriovActive
		{
			get
			{
				return this._sriovActive;
			}
			set
			{
				this._sriovActive = value;
			}
		}
		public int NumVirtualFunctionRequested
		{
			get
			{
				return this._numVirtualFunctionRequested;
			}
			set
			{
				this._numVirtualFunctionRequested = value;
			}
		}
		public int NumVirtualFunction
		{
			get
			{
				return this._numVirtualFunction;
			}
			set
			{
				this._numVirtualFunction = value;
			}
		}
		public int MaxVirtualFunctionSupported
		{
			get
			{
				return this._maxVirtualFunctionSupported;
			}
			set
			{
				this._maxVirtualFunctionSupported = value;
			}
		}
	}
}
