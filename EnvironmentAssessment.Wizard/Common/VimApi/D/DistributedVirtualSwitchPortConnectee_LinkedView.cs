namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchPortConnectee_LinkedView
	{
		protected ManagedEntity _connectedEntity;
		public ManagedEntity ConnectedEntity
		{
			get
			{
				return this._connectedEntity;
			}
			set
			{
				this._connectedEntity = value;
			}
		}
	}
}
