namespace EnvironmentAssessment.Common.VimApi
{
	public class VmValidateMaxDevice : VimFault
	{
		protected string _device;
		protected int _max;
		protected int _count;
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
		public int Max
		{
			get
			{
				return this._max;
			}
			set
			{
				this._max = value;
			}
		}
		public int Count
		{
			get
			{
				return this._count;
			}
			set
			{
				this._count = value;
			}
		}
	}
}
