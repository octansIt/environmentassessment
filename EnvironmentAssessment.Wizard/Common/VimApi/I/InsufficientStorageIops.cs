namespace EnvironmentAssessment.Common.VimApi
{
	public class InsufficientStorageIops : VimFault
	{
		protected long _unreservedIops;
		protected long _requestedIops;
		protected string _datastoreName;
		public long UnreservedIops
		{
			get
			{
				return this._unreservedIops;
			}
			set
			{
				this._unreservedIops = value;
			}
		}
		public long RequestedIops
		{
			get
			{
				return this._requestedIops;
			}
			set
			{
				this._requestedIops = value;
			}
		}
		public string DatastoreName
		{
			get
			{
				return this._datastoreName;
			}
			set
			{
				this._datastoreName = value;
			}
		}
	}
}
