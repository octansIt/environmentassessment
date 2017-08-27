namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPciPassthruInfo : DynamicData
	{
		protected string _id;
		protected string _dependentDevice;
		protected bool _passthruEnabled;
		protected bool _passthruCapable;
		protected bool _passthruActive;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string DependentDevice
		{
			get
			{
				return this._dependentDevice;
			}
			set
			{
				this._dependentDevice = value;
			}
		}
		public bool PassthruEnabled
		{
			get
			{
				return this._passthruEnabled;
			}
			set
			{
				this._passthruEnabled = value;
			}
		}
		public bool PassthruCapable
		{
			get
			{
				return this._passthruCapable;
			}
			set
			{
				this._passthruCapable = value;
			}
		}
		public bool PassthruActive
		{
			get
			{
				return this._passthruActive;
			}
			set
			{
				this._passthruActive = value;
			}
		}
	}
}
