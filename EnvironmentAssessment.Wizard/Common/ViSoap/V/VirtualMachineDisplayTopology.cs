namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineDisplayTopology : DynamicData
	{
		protected int _x;
		protected int _y;
		protected int _width;
		protected int _height;
		public int X
		{
			get
			{
				return this._x;
			}
			set
			{
				this._x = value;
			}
		}
		public int Y
		{
			get
			{
				return this._y;
			}
			set
			{
				this._y = value;
			}
		}
		public int Width
		{
			get
			{
				return this._width;
			}
			set
			{
				this._width = value;
			}
		}
		public int Height
		{
			get
			{
				return this._height;
			}
			set
			{
				this._height = value;
			}
		}
	}
}
