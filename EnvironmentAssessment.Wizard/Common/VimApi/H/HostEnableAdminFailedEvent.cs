namespace EnvironmentAssessment.Common.VimApi
{
	public class HostEnableAdminFailedEvent : HostEvent
	{
		protected Permission[] _permissions;
		public Permission[] Permissions
		{
			get
			{
				return this._permissions;
			}
			set
			{
				this._permissions = value;
			}
		}
	}
}
