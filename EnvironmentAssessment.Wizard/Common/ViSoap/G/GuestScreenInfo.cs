namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestScreenInfo : DynamicData
	{
		protected int _width;
		protected int _height;
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
