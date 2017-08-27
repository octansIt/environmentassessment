namespace EnvironmentAssessment.Common.VimApi
{
	public class HostIoFilterInfo : IoFilterInfo
	{
		protected bool _available;
		public bool Available
		{
			get
			{
				return this._available;
			}
			set
			{
				this._available = value;
			}
		}
	}
}
