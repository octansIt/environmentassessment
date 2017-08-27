namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualResourcePoolSpec_LinkedView
	{
		protected ManagedEntity[] _rpList;
		protected ManagedEntity[] _hubList;
		public ManagedEntity[] RpList
		{
			get
			{
				return this._rpList;
			}
			set
			{
				this._rpList = value;
			}
		}
		public ManagedEntity[] HubList
		{
			get
			{
				return this._hubList;
			}
			set
			{
				this._hubList = value;
			}
		}
	}
}
