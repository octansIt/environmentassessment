namespace EnvironmentAssessment.Common.VimApi
{
	public class PhysicalNicLinkInfo : DynamicData
	{
		protected int _speedMb;
		protected bool _duplex;
		public int SpeedMb
		{
			get
			{
				return this._speedMb;
			}
			set
			{
				this._speedMb = value;
			}
		}
		public bool Duplex
		{
			get
			{
				return this._duplex;
			}
			set
			{
				this._duplex = value;
			}
		}
	}
}
