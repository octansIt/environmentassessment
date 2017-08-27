namespace EnvironmentAssessment.Common.VimApi
{
	public class VRPEditSpec_LinkedView
	{
		protected ManagedEntity[] _addedHubs;
		protected ManagedEntity[] _removedHubs;
		public ManagedEntity[] AddedHubs
		{
			get
			{
				return this._addedHubs;
			}
			set
			{
				this._addedHubs = value;
			}
		}
		public ManagedEntity[] RemovedHubs
		{
			get
			{
				return this._removedHubs;
			}
			set
			{
				this._removedHubs = value;
			}
		}
	}
}
