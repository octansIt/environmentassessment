namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineVMCIDeviceOptionFilterSpecOption : DynamicData
	{
		protected ChoiceOption _action;
		protected ChoiceOption _protocol;
		protected ChoiceOption _direction;
		protected LongOption _lowerDstPortBoundary;
		protected LongOption _upperDstPortBoundary;
		public ChoiceOption Action
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
		public ChoiceOption Protocol
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
		public ChoiceOption Direction
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
		public LongOption LowerDstPortBoundary
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
		public LongOption UpperDstPortBoundary
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
