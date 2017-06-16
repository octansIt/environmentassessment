namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestPosixFileAttributes : GuestFileAttributes
	{
		protected int? _ownerId;
		protected int? _groupId;
		protected long? _permissions;
		public int? OwnerId
		{
			get
			{
				return this._ownerId;
			}
			set
			{
				this._ownerId = value;
			}
		}
		public int? GroupId
		{
			get
			{
				return this._groupId;
			}
			set
			{
				this._groupId = value;
			}
		}
		public long? Permissions
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
