namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineVMCIDeviceFilterSpec : DynamicData
	{
		protected long _rank;
		protected string _action;
		protected string _protocol;
		protected string _direction;
		protected long? _lowerDstPortBoundary;
		protected long? _upperDstPortBoundary;
		public long Rank
		{
			get
			{
				return this._rank;
			}
			set
			{
				this._rank = value;
			}
		}
		public string Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}
		public string Protocol
		{
			get
			{
				return this._protocol;
			}
			set
			{
				this._protocol = value;
			}
		}
		public string Direction
		{
			get
			{
				return this._direction;
			}
			set
			{
				this._direction = value;
			}
		}
		public long? LowerDstPortBoundary
		{
			get
			{
				return this._lowerDstPortBoundary;
			}
			set
			{
				this._lowerDstPortBoundary = value;
			}
		}
		public long? UpperDstPortBoundary
		{
			get
			{
				return this._upperDstPortBoundary;
			}
			set
			{
				this._upperDstPortBoundary = value;
			}
		}
	}
}
